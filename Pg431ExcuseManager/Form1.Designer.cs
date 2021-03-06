﻿namespace Pg431ExcuseManager
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.results = new System.Windows.Forms.TextBox();
            this.lastUsed = new System.Windows.Forms.DateTimePicker();
            this.folder = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.random = new System.Windows.Forms.Button();
            this.fileDate = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Excuse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Result";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Used";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "File Date";
            // 
            // description
            // 
            this.description.Enabled = false;
            this.description.Location = new System.Drawing.Point(81, 16);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(314, 20);
            this.description.TabIndex = 4;
            this.description.TextChanged += new System.EventHandler(this.description_TextChanged);
            // 
            // results
            // 
            this.results.Enabled = false;
            this.results.Location = new System.Drawing.Point(81, 41);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(314, 20);
            this.results.TabIndex = 5;
            this.results.TextChanged += new System.EventHandler(this.results_TextChanged);
            // 
            // lastUsed
            // 
            this.lastUsed.Enabled = false;
            this.lastUsed.Location = new System.Drawing.Point(81, 67);
            this.lastUsed.Name = "lastUsed";
            this.lastUsed.Size = new System.Drawing.Size(200, 20);
            this.lastUsed.TabIndex = 6;
            this.lastUsed.ValueChanged += new System.EventHandler(this.lastUsed_ValueChanged);
            // 
            // folder
            // 
            this.folder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.folder.Location = new System.Drawing.Point(26, 134);
            this.folder.Name = "folder";
            this.folder.Size = new System.Drawing.Size(75, 23);
            this.folder.TabIndex = 8;
            this.folder.Text = "Set Folder";
            this.folder.UseVisualStyleBackColor = false;
            this.folder.Click += new System.EventHandler(this.folder_Click);
            // 
            // save
            // 
            this.save.Enabled = false;
            this.save.Location = new System.Drawing.Point(124, 134);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 9;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // open
            // 
            this.open.Enabled = false;
            this.open.Location = new System.Drawing.Point(222, 134);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(75, 23);
            this.open.TabIndex = 10;
            this.open.Text = "Open";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // random
            // 
            this.random.Enabled = false;
            this.random.Location = new System.Drawing.Point(320, 134);
            this.random.Name = "random";
            this.random.Size = new System.Drawing.Size(75, 23);
            this.random.TabIndex = 11;
            this.random.Text = "Random";
            this.random.UseVisualStyleBackColor = true;
            this.random.Click += new System.EventHandler(this.random_Click);
            // 
            // fileDate
            // 
            this.fileDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fileDate.Location = new System.Drawing.Point(78, 100);
            this.fileDate.Name = "fileDate";
            this.fileDate.Size = new System.Drawing.Size(317, 23);
            this.fileDate.TabIndex = 12;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 169);
            this.Controls.Add(this.fileDate);
            this.Controls.Add(this.random);
            this.Controls.Add(this.open);
            this.Controls.Add(this.save);
            this.Controls.Add(this.folder);
            this.Controls.Add(this.lastUsed);
            this.Controls.Add(this.results);
            this.Controls.Add(this.description);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Execuse Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox results;
        private System.Windows.Forms.DateTimePicker lastUsed;
        private System.Windows.Forms.Button folder;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button random;
        private System.Windows.Forms.Label fileDate;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

