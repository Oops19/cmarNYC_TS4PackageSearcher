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

namespace TS4PackageSearcher
{
    public partial class PathPrompt : Form
    {
        public PathPrompt()
        {
            InitializeComponent();
        }

        public PathPrompt(string path)
        {
            InitializeComponent();
            TS4PathString.Text = path;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.TS4Path = TS4PathString.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void Folder_button_Click(object sender, EventArgs e)
        {
            Ookii.Dialogs.VistaFolderBrowserDialog findFolder = new Ookii.Dialogs.VistaFolderBrowserDialog();
            findFolder.Description = "Select the folder where your game packages are located";
            findFolder.RootFolder = Environment.SpecialFolder.ProgramFilesX86;
            findFolder.ShowNewFolderButton = false;
            DialogResult res = findFolder.ShowDialog();
            if (res == DialogResult.OK)
            {
                TS4PathString.Text = findFolder.SelectedPath;
            }
        }
    }
}
