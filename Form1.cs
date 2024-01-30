/* TS4 Package Searcher, a tool for finding game resources for The Sims 4,
   Copyright (C) 2016  C. Marinetti

   This program is free software: you can redistribute it and/or modify
   it under the terms of the GNU General Public License as published by
   the Free Software Foundation, either version 3 of the License, or
   (at your option) any later version.

   This program is distributed in the hope that it will be useful,
   but WITHOUT ANY WARRANTY; without even the implied warranty of
   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
   GNU General Public License for more details.

   You should have received a copy of the GNU General Public License
   along with this program.  If not, see <http://www.gnu.org/licenses/>. 
   The author may be contacted at modthesims.info, username cmarNYC. */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using s4pi.Interfaces;
using s4pi.Package;

namespace TS4PackageSearcher
{
    public partial class Form1 : Form
    {
        string version = "1.0.0.4";
        Package[] gamePacks;
        string[] gamePaths;
        UInt32 typeID = 0, groupID = 0;
        UInt64 instanceID = 0;

        public Form1()
        {
            InitializeComponent();
            this.Text = "TS4 Package Searcher v" + version + " by cmar";
            try
            {
                if (String.Compare(Properties.Settings.Default.TS4Path, " ") <= 0)
                {
                    string tmp = (string)Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Maxis\\The Sims 4", "Install Dir", null);
                    if (tmp != null) Properties.Settings.Default.TS4Path = tmp;
                    //MessageBox.Show(tmp);
                    Properties.Settings.Default.Save();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error in detecting game file path: " + e.Message + Environment.NewLine + e.StackTrace);
            }
            FindGamePacks();
        }
        private bool FindGamePacks()
        {
            string TS4FilesPath = Properties.Settings.Default.TS4Path;
            try
            {
                gamePaths = Directory.GetFiles(TS4FilesPath, "*.package", SearchOption.AllDirectories);
            }
            catch (DirectoryNotFoundException e)
            {
                MessageBox.Show("Your game packages path is invalid! Please go to File / Change Settings and correct it or make it blank to reset, then restart." 
                    + Environment.NewLine + e.Message + Environment.NewLine + e.StackTrace);
                return false;
            }
            catch (IOException e)
            {
                MessageBox.Show("Your game packages path is invalid or a network error has occurred! Please go to File / Change Settings and correct it or make it blank to reset, then restart."
                    + Environment.NewLine + e.Message + Environment.NewLine + e.StackTrace);
                return false;
            }
            catch (ArgumentException e)
            {
                MessageBox.Show("Your game packages path is not specified correctly! Please go to File / Change Settings and correct it or make it blank to reset, then restart."
                    + Environment.NewLine + e.Message + Environment.NewLine + e.StackTrace);
                return false;
            }
            catch (UnauthorizedAccessException e)
            {
                MessageBox.Show("You do not have the required permissions to access the game packages folder! Please restart with admin privileges."
                    + Environment.NewLine + e.Message + Environment.NewLine + e.StackTrace);
                return false;
            }
            if (gamePaths.Length == 0)
            {
                MessageBox.Show("Can't find game packages! Please go to File / Change Settings and correct the game packages path or make it blank to reset, then restart.");
                return false;
            }
            try
            {
                Array.Sort(gamePaths);
                gamePacks = new Package[gamePaths.Length];
                for (int i = 0; i < gamePaths.Length; i++)
                {
                    gamePacks[i] = OpenPackage(gamePaths[i], false);
                    if (gamePacks[i] == null)
                    {
                        MessageBox.Show("Can't read game packages!");
                        return false;
                    }
                }
            }
            catch (UnauthorizedAccessException e)
            {
                MessageBox.Show("You do not have the required permissions to open the game packages! Please restart with admin privileges."
                    + Environment.NewLine + e.Message + Environment.NewLine + e.StackTrace);
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + Environment.NewLine + e.StackTrace);
                return false;
            }
            return true;
        }

        internal Package OpenPackage(string packagePath, bool readwrite)
        {
            try
            {
                Package package = (Package)Package.OpenPackage(0, packagePath, readwrite);
                return package;
            }
            catch
            {
                MessageBox.Show("Unable to read valid package data from " + packagePath);
                return null;
            }
        }

        private void SearchGo_button_Click(object sender, EventArgs e)
        {
            bool noType = true, noGroup = true, noInstance = true;
            try
            {
                if (String.Compare(TypeID.Text, " ") > 0)
                {
                    typeID = UInt32.Parse(TypeID.Text.Replace("0x", "").Replace("0X", ""), System.Globalization.NumberStyles.HexNumber);
                    noType = false;
                }
                if (String.Compare(GroupID.Text, " ") > 0)
                {
                    groupID = UInt32.Parse(GroupID.Text.Replace("0x", "").Replace("0X", ""), System.Globalization.NumberStyles.HexNumber);
                    noGroup = false;
                }
                if (String.Compare(InstanceID.Text, " ") > 0)
                {
                    instanceID = UInt64.Parse(InstanceID.Text.Replace("0x", "").Replace("0X", ""), System.Globalization.NumberStyles.HexNumber);
                    noInstance = false;
                }
            }
            catch
            {
                MessageBox.Show("Each field must be blank or contain a valid hex number!");
                return;
            }
            Predicate<IResourceIndexEntry> getID = r => (noType || r.ResourceType == typeID) && (noGroup || r.ResourceGroup == groupID) &&
                                                            (noInstance || r.Instance == instanceID);
            PackageFoundList_dataGridView.Rows.Clear();
            for (int i = 0; i < gamePacks.Length; i++)
            {
                List<IResourceIndexEntry> ires = gamePacks[i].FindAll(getID);
                if (ires != null && ires.Count > 0)
                {
                    PackageFoundList_dataGridView.Rows.Add(gamePaths[i]);
                }
            }
            if (PackageFoundList_dataGridView.RowCount == 0)
            {
                PackageFoundList_dataGridView.Rows.Add("Not found");
            }
        }

        private void gamePackList_button_Click(object sender, EventArgs e)
        {
            string lst = "";
            foreach (string s in gamePaths)
            {
                lst += s + Environment.NewLine;
            }
            Form gameList = new Form() { Width = 750, Height = 700, Text = "Game Packages to Search" };
            Button OKbutton = new Button() { Text = "Okay", Left = 300, Top = 615, Width = 100, Height = 30 };
            TextBox list = new TextBox() { Left = 10, Top = 10, Width = 700, Height = 600, Multiline = true, ScrollBars = ScrollBars.Both };
            list.Text = lst;
            gameList.Controls.Add(OKbutton);
            gameList.Controls.Add(list);
            OKbutton.Click += (senderb, ev) => { gameList.Close(); };
            gameList.ShowDialog();
        }

        private void PackageFoundList_dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (File.Exists(PackageFoundList_dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()))
            {
                System.Diagnostics.Process.Start(PackageFoundList_dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            }
            else
            {
                if (String.Compare(PackageFoundList_dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), "Not found") != 0)
                {
                    MessageBox.Show("File '" + PackageFoundList_dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() + "' does not exist!");
                }
            }
        }

        private void CopyTGI_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.Compare(TypeID.Text, " ") > 0)
                {
                    typeID = UInt32.Parse(TypeID.Text.Replace("0x", "").Replace("0X", ""), System.Globalization.NumberStyles.HexNumber);
                }
                else
                {
                    typeID = 0;
                }
                if (String.Compare(GroupID.Text, " ") > 0)
                {
                    groupID = UInt32.Parse(GroupID.Text.Replace("0x", "").Replace("0X", ""), System.Globalization.NumberStyles.HexNumber);
                }
                else
                {
                    groupID = 0;
                }
                if (String.Compare(InstanceID.Text, " ") > 0)
                {
                    instanceID = UInt64.Parse(InstanceID.Text.Replace("0x", "").Replace("0X", ""), System.Globalization.NumberStyles.HexNumber);
                }
                else
                {
                    instanceID = 0;
                }
            }
            catch
            {
                MessageBox.Show("Each field must be blank or contain a valid hex number!");
                return;
            }

            TGI tgi = new TGI(typeID, groupID, instanceID);
            Clipboard.SetText(tgi.ToString());
        }

        private void PasteTGI_button_Click(object sender, EventArgs e)
        {
            try
            {
                TGI tgi = new TGI(Clipboard.GetText());
                if (tgi != null)
                {
                    TypeID.Text = tgi.Type.ToString("X8");
                    GroupID.Text = tgi.Group.ToString("X8");
                    InstanceID.Text = tgi.Instance.ToString("X16");
                }
            }
            catch
            {
                MessageBox.Show("'" + Clipboard.GetText() + "' is not a valid TGI!");
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new PathPrompt(Properties.Settings.Default.TS4Path);
            f.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TS4 Package Searcher v" + version + " by cmar" + Environment.NewLine +
                "This is free software under the GNU licence," + Environment.NewLine +
                "available from www.modthesims.info");
        }
    }
}
