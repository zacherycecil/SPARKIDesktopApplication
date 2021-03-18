﻿
namespace SPARKIDesktopApp
{
    partial class FormCreateOrLoad
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
            this.createButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(41, 111);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(99, 41);
            this.createButton.TabIndex = 0;
            this.createButton.Text = "Create Profile";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(190, 111);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(99, 41);
            this.loadButton.TabIndex = 1;
            this.loadButton.Text = "Load Profile";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Create or load a S.P.A.R.K.I. profile:";
            // 
            // FormCreateOrLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 211);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.createButton);
            this.Name = "FormCreateOrLoad";
            this.Text = "S.P.A.R.K.I. Desktop Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Label label1;
    }
}