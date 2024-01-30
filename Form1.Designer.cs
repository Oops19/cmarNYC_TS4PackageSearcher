namespace TS4PackageSearcher
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TypeID = new System.Windows.Forms.TextBox();
            this.GroupID = new System.Windows.Forms.TextBox();
            this.InstanceID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SearchGo_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.gamePackList_button = new System.Windows.Forms.Button();
            this.PackageFoundList_dataGridView = new System.Windows.Forms.DataGridView();
            this.PackageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.CopyTGI_button = new System.Windows.Forms.Button();
            this.PasteTGI_button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.PackageFoundList_dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type:";
            // 
            // TypeID
            // 
            this.TypeID.Location = new System.Drawing.Point(77, 68);
            this.TypeID.MaxLength = 8;
            this.TypeID.Name = "TypeID";
            this.TypeID.Size = new System.Drawing.Size(100, 22);
            this.TypeID.TabIndex = 2;
            this.TypeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GroupID
            // 
            this.GroupID.Location = new System.Drawing.Point(254, 67);
            this.GroupID.MaxLength = 8;
            this.GroupID.Name = "GroupID";
            this.GroupID.Size = new System.Drawing.Size(100, 22);
            this.GroupID.TabIndex = 3;
            this.GroupID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // InstanceID
            // 
            this.InstanceID.Location = new System.Drawing.Point(446, 67);
            this.InstanceID.MaxLength = 16;
            this.InstanceID.Name = "InstanceID";
            this.InstanceID.Size = new System.Drawing.Size(200, 22);
            this.InstanceID.TabIndex = 4;
            this.InstanceID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Group:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Instance:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(721, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Enter any combination of Type, and/or Group, and/or Instance to search for. Do no" +
    "t start with \'0x\'.\r\n";
            // 
            // SearchGo_button
            // 
            this.SearchGo_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchGo_button.Location = new System.Drawing.Point(659, 53);
            this.SearchGo_button.Name = "SearchGo_button";
            this.SearchGo_button.Size = new System.Drawing.Size(158, 51);
            this.SearchGo_button.TabIndex = 9;
            this.SearchGo_button.Text = "Search!";
            this.SearchGo_button.UseVisualStyleBackColor = true;
            this.SearchGo_button.Click += new System.EventHandler(this.SearchGo_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Packages IDs are found in:";
            // 
            // gamePackList_button
            // 
            this.gamePackList_button.Location = new System.Drawing.Point(30, 108);
            this.gamePackList_button.Name = "gamePackList_button";
            this.gamePackList_button.Size = new System.Drawing.Size(237, 36);
            this.gamePackList_button.TabIndex = 12;
            this.gamePackList_button.Text = "Show list of all game packages";
            this.gamePackList_button.UseVisualStyleBackColor = true;
            this.gamePackList_button.Click += new System.EventHandler(this.gamePackList_button_Click);
            // 
            // PackageFoundList_dataGridView
            // 
            this.PackageFoundList_dataGridView.AllowUserToAddRows = false;
            this.PackageFoundList_dataGridView.AllowUserToDeleteRows = false;
            this.PackageFoundList_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PackageFoundList_dataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.PackageFoundList_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PackageFoundList_dataGridView.ColumnHeadersVisible = false;
            this.PackageFoundList_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PackageName});
            this.PackageFoundList_dataGridView.Location = new System.Drawing.Point(32, 172);
            this.PackageFoundList_dataGridView.Name = "PackageFoundList_dataGridView";
            this.PackageFoundList_dataGridView.ReadOnly = true;
            this.PackageFoundList_dataGridView.RowHeadersVisible = false;
            this.PackageFoundList_dataGridView.RowTemplate.Height = 24;
            this.PackageFoundList_dataGridView.Size = new System.Drawing.Size(785, 338);
            this.PackageFoundList_dataGridView.TabIndex = 13;
            this.PackageFoundList_dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PackageFoundList_dataGridView_CellDoubleClick);
            // 
            // PackageName
            // 
            this.PackageName.HeaderText = "Column1";
            this.PackageName.Name = "PackageName";
            this.PackageName.ReadOnly = true;
            this.PackageName.Width = 750;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(611, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Double-click package to open it";
            // 
            // CopyTGI_button
            // 
            this.CopyTGI_button.Location = new System.Drawing.Point(311, 108);
            this.CopyTGI_button.Name = "CopyTGI_button";
            this.CopyTGI_button.Size = new System.Drawing.Size(120, 36);
            this.CopyTGI_button.TabIndex = 15;
            this.CopyTGI_button.Text = "Copy TGI/RK";
            this.CopyTGI_button.UseVisualStyleBackColor = true;
            this.CopyTGI_button.Click += new System.EventHandler(this.CopyTGI_button_Click);
            // 
            // PasteTGI_button
            // 
            this.PasteTGI_button.Location = new System.Drawing.Point(437, 108);
            this.PasteTGI_button.Name = "PasteTGI_button";
            this.PasteTGI_button.Size = new System.Drawing.Size(120, 36);
            this.PasteTGI_button.TabIndex = 16;
            this.PasteTGI_button.Text = "Paste TGI/RK";
            this.PasteTGI_button.UseVisualStyleBackColor = true;
            this.PasteTGI_button.Click += new System.EventHandler(this.PasteTGI_button_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(847, 27);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(59, 23);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 529);
            this.Controls.Add(this.PasteTGI_button);
            this.Controls.Add(this.CopyTGI_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PackageFoundList_dataGridView);
            this.Controls.Add(this.gamePackList_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SearchGo_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InstanceID);
            this.Controls.Add(this.GroupID);
            this.Controls.Add(this.TypeID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PackageFoundList_dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TypeID;
        private System.Windows.Forms.TextBox GroupID;
        private System.Windows.Forms.TextBox InstanceID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SearchGo_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button gamePackList_button;
        private System.Windows.Forms.DataGridView PackageFoundList_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackageName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CopyTGI_button;
        private System.Windows.Forms.Button PasteTGI_button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

