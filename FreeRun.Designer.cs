
namespace SPARKIDesktopApp
{
    partial class FreeRun
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
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.profileLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.modeLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.unsavedChangeLabel = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.profileNameLabel = new System.Windows.Forms.Label();
            this.profileModeLabel = new System.Windows.Forms.Label();
            this.macroLabel1 = new System.Windows.Forms.Label();
            this.macroCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(28, 32);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(167, 57);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save Profile";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.loadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadButton.Location = new System.Drawing.Point(215, 32);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(185, 56);
            this.loadButton.TabIndex = 1;
            this.loadButton.Text = "Load Profile";
            this.loadButton.UseVisualStyleBackColor = false;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // newButton
            // 
            this.newButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.newButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.Location = new System.Drawing.Point(422, 32);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(189, 56);
            this.newButton.TabIndex = 2;
            this.newButton.Text = "New Profile";
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // profileLabel
            // 
            this.profileLabel.AutoSize = true;
            this.profileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileLabel.Location = new System.Drawing.Point(25, 111);
            this.profileLabel.Name = "profileLabel";
            this.profileLabel.Size = new System.Drawing.Size(197, 29);
            this.profileLabel.TabIndex = 3;
            this.profileLabel.Text = "Current Profile: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(28, 164);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1220, 545);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // modeLabel
            // 
            this.modeLabel.AutoSize = true;
            this.modeLabel.BackColor = System.Drawing.Color.DarkGray;
            this.modeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeLabel.Location = new System.Drawing.Point(56, 190);
            this.modeLabel.Name = "modeLabel";
            this.modeLabel.Size = new System.Drawing.Size(86, 29);
            this.modeLabel.TabIndex = 5;
            this.modeLabel.Text = "Mode:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gray;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(707, 570);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(507, 106);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // unsavedChangeLabel
            // 
            this.unsavedChangeLabel.AutoSize = true;
            this.unsavedChangeLabel.BackColor = System.Drawing.Color.Gray;
            this.unsavedChangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unsavedChangeLabel.ForeColor = System.Drawing.Color.Red;
            this.unsavedChangeLabel.Location = new System.Drawing.Point(736, 613);
            this.unsavedChangeLabel.Name = "unsavedChangeLabel";
            this.unsavedChangeLabel.Size = new System.Drawing.Size(0, 20);
            this.unsavedChangeLabel.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1016, 595);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(167, 57);
            this.button4.TabIndex = 10;
            this.button4.Text = "Stream to SPARKI";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // profileNameLabel
            // 
            this.profileNameLabel.AutoSize = true;
            this.profileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileNameLabel.Location = new System.Drawing.Point(228, 111);
            this.profileNameLabel.Name = "profileNameLabel";
            this.profileNameLabel.Size = new System.Drawing.Size(133, 29);
            this.profileNameLabel.TabIndex = 11;
            this.profileNameLabel.Text = "NewProfile";
            // 
            // profileModeLabel
            // 
            this.profileModeLabel.AutoSize = true;
            this.profileModeLabel.BackColor = System.Drawing.Color.DarkGray;
            this.profileModeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileModeLabel.Location = new System.Drawing.Point(148, 190);
            this.profileModeLabel.Name = "profileModeLabel";
            this.profileModeLabel.Size = new System.Drawing.Size(115, 29);
            this.profileModeLabel.TabIndex = 12;
            this.profileModeLabel.Text = "Free-Run";
            // 
            // macroLabel1
            // 
            this.macroLabel1.AutoSize = true;
            this.macroLabel1.BackColor = System.Drawing.Color.DarkGray;
            this.macroLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macroLabel1.Location = new System.Drawing.Point(56, 246);
            this.macroLabel1.Name = "macroLabel1";
            this.macroLabel1.Size = new System.Drawing.Size(135, 29);
            this.macroLabel1.TabIndex = 13;
            this.macroLabel1.Text = "Macro file:";
            // 
            // macroCB
            // 
            this.macroCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.macroCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macroCB.FormattingEnabled = true;
            this.macroCB.Location = new System.Drawing.Point(61, 298);
            this.macroCB.Name = "macroCB";
            this.macroCB.Size = new System.Drawing.Size(220, 28);
            this.macroCB.TabIndex = 15;
            // 
            // FreeRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 736);
            this.Controls.Add(this.macroCB);
            this.Controls.Add(this.macroLabel1);
            this.Controls.Add(this.profileModeLabel);
            this.Controls.Add(this.profileNameLabel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.unsavedChangeLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.modeLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.profileLabel);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Name = "FreeRun";
            this.Text = "S.P.A.R.K.I. Windows Desktop Application";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FreeRunFormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Label profileLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label modeLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label unsavedChangeLabel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label profileNameLabel;
        private System.Windows.Forms.Label profileModeLabel;
        private System.Windows.Forms.Label macroLabel1;
        private System.Windows.Forms.ComboBox macroCB;
    }
}

