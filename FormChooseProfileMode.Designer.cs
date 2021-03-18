
namespace SPARKIDesktopApp
{
    partial class FormChooseProfileMode
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
            this.therapeuticButton = new System.Windows.Forms.Button();
            this.freeRunButton = new System.Windows.Forms.Button();
            this.fesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // therapeuticButton
            // 
            this.therapeuticButton.Location = new System.Drawing.Point(12, 111);
            this.therapeuticButton.Name = "therapeuticButton";
            this.therapeuticButton.Size = new System.Drawing.Size(100, 41);
            this.therapeuticButton.TabIndex = 1;
            this.therapeuticButton.Text = "Therapeutic";
            this.therapeuticButton.UseVisualStyleBackColor = true;
            this.therapeuticButton.Click += new System.EventHandler(this.therapeuticButton_Click);
            // 
            // freeRunButton
            // 
            this.freeRunButton.Location = new System.Drawing.Point(225, 111);
            this.freeRunButton.Name = "freeRunButton";
            this.freeRunButton.Size = new System.Drawing.Size(100, 41);
            this.freeRunButton.TabIndex = 2;
            this.freeRunButton.Text = "Free-Run";
            this.freeRunButton.UseVisualStyleBackColor = true;
            this.freeRunButton.Click += new System.EventHandler(this.freeRunButton_Click);
            // 
            // fesButton
            // 
            this.fesButton.Location = new System.Drawing.Point(118, 111);
            this.fesButton.Name = "fesButton";
            this.fesButton.Size = new System.Drawing.Size(101, 41);
            this.fesButton.TabIndex = 3;
            this.fesButton.Text = "FES";
            this.fesButton.UseVisualStyleBackColor = true;
            this.fesButton.Click += new System.EventHandler(this.fesButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose a profile mode:";
            // 
            // FormChooseProfileMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 211);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fesButton);
            this.Controls.Add(this.freeRunButton);
            this.Controls.Add(this.therapeuticButton);
            this.Name = "FormChooseProfileMode";
            this.Text = "S.P.A.R.K.I. Desktop Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button therapeuticButton;
        private System.Windows.Forms.Button freeRunButton;
        private System.Windows.Forms.Button fesButton;
        private System.Windows.Forms.Label label1;
    }
}