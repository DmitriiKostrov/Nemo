﻿namespace Nemo.GUI
{
    partial class FilterNameForm
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
            this.FilterNameTextBox = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FilterNameTextBox
            // 
            this.FilterNameTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.FilterNameTextBox.Location = new System.Drawing.Point(0, 0);
            this.FilterNameTextBox.Name = "FilterNameTextBox";
            this.FilterNameTextBox.Size = new System.Drawing.Size(231, 20);
            this.FilterNameTextBox.TabIndex = 0;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(78, 35);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(72, 23);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(156, 35);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // FilterNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 61);
            this.ControlBox = false;
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.FilterNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FilterNameForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Specify filter name";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FilterNameForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FilterNameTextBox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
    }
}