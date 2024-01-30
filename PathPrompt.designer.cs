namespace TS4PackageSearcher
{
    partial class PathPrompt
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TS4PathString = new System.Windows.Forms.TextBox();
            this.Folder_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Location of TS4 game\r\ninstallation directory:";
            // 
            // TS4PathString
            // 
            this.TS4PathString.Location = new System.Drawing.Point(169, 34);
            this.TS4PathString.Name = "TS4PathString";
            this.TS4PathString.Size = new System.Drawing.Size(381, 22);
            this.TS4PathString.TabIndex = 4;
            // 
            // Folder_button
            // 
            this.Folder_button.Location = new System.Drawing.Point(556, 27);
            this.Folder_button.Name = "Folder_button";
            this.Folder_button.Size = new System.Drawing.Size(93, 36);
            this.Folder_button.TabIndex = 5;
            this.Folder_button.Text = "Select";
            this.Folder_button.UseVisualStyleBackColor = true;
            this.Folder_button.Click += new System.EventHandler(this.Folder_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(337, 34);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select the Sims 4 game top folder, not a subfolder!\r\nEx: C:\\Program Files (x86)\\O" +
    "rigin Games\\The Sims 4";
            // 
            // CreatorPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 207);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Folder_button);
            this.Controls.Add(this.TS4PathString);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Name = "CreatorPrompt";
            this.Text = "TS4 Game Files Location";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TS4PathString;
        private System.Windows.Forms.Button Folder_button;
        private System.Windows.Forms.Label label3;
    }
}