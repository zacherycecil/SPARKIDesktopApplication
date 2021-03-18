
namespace SPARKIDesktopApp
{
    partial class Therapeutic
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
            this.electrodeDropdown = new System.Windows.Forms.ComboBox();
            this.therapeuticTable = new System.Windows.Forms.TableLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rampingTimePulseWidthTB = new System.Windows.Forms.TextBox();
            this.freqTB = new System.Windows.Forms.TextBox();
            this.rampingTimeFreqTB = new System.Windows.Forms.TextBox();
            this.pulseWidthTB = new System.Windows.Forms.TextBox();
            this.stimTimeTB = new System.Windows.Forms.TextBox();
            this.rampingTimeAmpTB = new System.Windows.Forms.TextBox();
            this.onTimeTB = new System.Windows.Forms.TextBox();
            this.offTimeTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SyncLabel = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.profileNameLabel = new System.Windows.Forms.Label();
            this.profileModeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.therapeuticTable.SuspendLayout();
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
            this.saveButton.Click += new System.EventHandler(this.button1_Click);
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
            // electrodeDropdown
            // 
            this.electrodeDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.electrodeDropdown.FormattingEnabled = true;
            this.electrodeDropdown.Location = new System.Drawing.Point(61, 241);
            this.electrodeDropdown.Name = "electrodeDropdown";
            this.electrodeDropdown.Size = new System.Drawing.Size(225, 28);
            this.electrodeDropdown.TabIndex = 6;
            this.electrodeDropdown.SelectedIndexChanged += new System.EventHandler(this.ElectrodeDropDown);
            // 
            // therapeuticTable
            // 
            this.therapeuticTable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.therapeuticTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.therapeuticTable.ColumnCount = 6;
            this.therapeuticTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.therapeuticTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.therapeuticTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.71429F));
            this.therapeuticTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.therapeuticTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.therapeuticTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.71429F));
            this.therapeuticTable.Controls.Add(this.label16, 5, 3);
            this.therapeuticTable.Controls.Add(this.label15, 4, 3);
            this.therapeuticTable.Controls.Add(this.label14, 2, 3);
            this.therapeuticTable.Controls.Add(this.label13, 1, 3);
            this.therapeuticTable.Controls.Add(this.label12, 5, 2);
            this.therapeuticTable.Controls.Add(this.label11, 4, 2);
            this.therapeuticTable.Controls.Add(this.label10, 2, 2);
            this.therapeuticTable.Controls.Add(this.label9, 1, 2);
            this.therapeuticTable.Controls.Add(this.label8, 5, 1);
            this.therapeuticTable.Controls.Add(this.label7, 4, 1);
            this.therapeuticTable.Controls.Add(this.label6, 2, 1);
            this.therapeuticTable.Controls.Add(this.label5, 1, 1);
            this.therapeuticTable.Controls.Add(this.label4, 5, 0);
            this.therapeuticTable.Controls.Add(this.label3, 4, 0);
            this.therapeuticTable.Controls.Add(this.label2, 2, 0);
            this.therapeuticTable.Controls.Add(this.rampingTimePulseWidthTB, 0, 1);
            this.therapeuticTable.Controls.Add(this.freqTB, 0, 0);
            this.therapeuticTable.Controls.Add(this.rampingTimeFreqTB, 3, 0);
            this.therapeuticTable.Controls.Add(this.pulseWidthTB, 0, 2);
            this.therapeuticTable.Controls.Add(this.stimTimeTB, 0, 3);
            this.therapeuticTable.Controls.Add(this.rampingTimeAmpTB, 3, 1);
            this.therapeuticTable.Controls.Add(this.onTimeTB, 3, 2);
            this.therapeuticTable.Controls.Add(this.offTimeTB, 3, 3);
            this.therapeuticTable.Controls.Add(this.label1, 1, 0);
            this.therapeuticTable.Location = new System.Drawing.Point(61, 287);
            this.therapeuticTable.Name = "therapeuticTable";
            this.therapeuticTable.RowCount = 4;
            this.therapeuticTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.therapeuticTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.therapeuticTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.therapeuticTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.therapeuticTable.Size = new System.Drawing.Size(731, 252);
            this.therapeuticTable.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(474, 209);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 20);
            this.label16.TabIndex = 30;
            this.label16.Text = "Off Time";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(421, 209);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 20);
            this.label15.TabIndex = 29;
            this.label15.Text = "sec";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(112, 209);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 20);
            this.label14.TabIndex = 28;
            this.label14.Text = "Stimulation Time";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(59, 209);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 20);
            this.label13.TabIndex = 27;
            this.label13.Text = "min";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(474, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 20);
            this.label12.TabIndex = 26;
            this.label12.Text = "On Time";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(421, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "sec";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(112, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Pulse Width";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(59, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "ms";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(474, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Ramping Time (Amplitude)";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(421, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "sec";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(112, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Ramping Time (Pulse Width)";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "sec";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(474, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Ramping Time (Frequency)";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(421, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "sec";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Frequency";
            // 
            // rampingTimePulseWidthTB
            // 
            this.rampingTimePulseWidthTB.AccessibleDescription = "1";
            this.rampingTimePulseWidthTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rampingTimePulseWidthTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rampingTimePulseWidthTB.Location = new System.Drawing.Point(6, 80);
            this.rampingTimePulseWidthTB.Name = "rampingTimePulseWidthTB";
            this.rampingTimePulseWidthTB.Size = new System.Drawing.Size(44, 29);
            this.rampingTimePulseWidthTB.TabIndex = 13;
            this.rampingTimePulseWidthTB.TextChanged += new System.EventHandler(this.propertyTextBox_TextChanged);
            this.rampingTimePulseWidthTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.propertyTextBox_KeyPress);
            // 
            // freqTB
            // 
            this.freqTB.AccessibleDescription = "0";
            this.freqTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.freqTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freqTB.Location = new System.Drawing.Point(6, 18);
            this.freqTB.Name = "freqTB";
            this.freqTB.Size = new System.Drawing.Size(44, 29);
            this.freqTB.TabIndex = 8;
            this.freqTB.TextChanged += new System.EventHandler(this.propertyTextBox_TextChanged);
            this.freqTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.propertyTextBox_KeyPress);
            // 
            // rampingTimeFreqTB
            // 
            this.rampingTimeFreqTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rampingTimeFreqTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rampingTimeFreqTB.Location = new System.Drawing.Point(368, 18);
            this.rampingTimeFreqTB.Name = "rampingTimeFreqTB";
            this.rampingTimeFreqTB.Size = new System.Drawing.Size(44, 29);
            this.rampingTimeFreqTB.TabIndex = 7;
            this.rampingTimeFreqTB.TextChanged += new System.EventHandler(this.propertyTextBox_TextChanged);
            this.rampingTimeFreqTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.propertyTextBox_KeyPress);
            // 
            // pulseWidthTB
            // 
            this.pulseWidthTB.AccessibleDescription = "2";
            this.pulseWidthTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pulseWidthTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pulseWidthTB.Location = new System.Drawing.Point(6, 142);
            this.pulseWidthTB.Name = "pulseWidthTB";
            this.pulseWidthTB.Size = new System.Drawing.Size(44, 29);
            this.pulseWidthTB.TabIndex = 9;
            this.pulseWidthTB.TextChanged += new System.EventHandler(this.propertyTextBox_TextChanged);
            this.pulseWidthTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.propertyTextBox_KeyPress);
            // 
            // stimTimeTB
            // 
            this.stimTimeTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.stimTimeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stimTimeTB.Location = new System.Drawing.Point(6, 204);
            this.stimTimeTB.Name = "stimTimeTB";
            this.stimTimeTB.Size = new System.Drawing.Size(44, 29);
            this.stimTimeTB.TabIndex = 14;
            this.stimTimeTB.TextChanged += new System.EventHandler(this.propertyTextBox_TextChanged);
            this.stimTimeTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.propertyTextBox_KeyPress);
            // 
            // rampingTimeAmpTB
            // 
            this.rampingTimeAmpTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rampingTimeAmpTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rampingTimeAmpTB.Location = new System.Drawing.Point(368, 80);
            this.rampingTimeAmpTB.Name = "rampingTimeAmpTB";
            this.rampingTimeAmpTB.Size = new System.Drawing.Size(44, 29);
            this.rampingTimeAmpTB.TabIndex = 10;
            this.rampingTimeAmpTB.TextChanged += new System.EventHandler(this.propertyTextBox_TextChanged);
            this.rampingTimeAmpTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.propertyTextBox_KeyPress);
            // 
            // onTimeTB
            // 
            this.onTimeTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.onTimeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onTimeTB.Location = new System.Drawing.Point(368, 142);
            this.onTimeTB.Name = "onTimeTB";
            this.onTimeTB.Size = new System.Drawing.Size(44, 29);
            this.onTimeTB.TabIndex = 11;
            this.onTimeTB.TextChanged += new System.EventHandler(this.propertyTextBox_TextChanged);
            this.onTimeTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.propertyTextBox_KeyPress);
            // 
            // offTimeTB
            // 
            this.offTimeTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.offTimeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offTimeTB.Location = new System.Drawing.Point(368, 204);
            this.offTimeTB.Name = "offTimeTB";
            this.offTimeTB.Size = new System.Drawing.Size(44, 29);
            this.offTimeTB.TabIndex = 12;
            this.offTimeTB.TextChanged += new System.EventHandler(this.propertyTextBox_TextChanged);
            this.offTimeTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.propertyTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Hz";
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
            // SyncLabel
            // 
            this.SyncLabel.AutoSize = true;
            this.SyncLabel.BackColor = System.Drawing.Color.Gray;
            this.SyncLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SyncLabel.ForeColor = System.Drawing.Color.Red;
            this.SyncLabel.Location = new System.Drawing.Point(736, 613);
            this.SyncLabel.Name = "SyncLabel";
            this.SyncLabel.Size = new System.Drawing.Size(210, 20);
            this.SyncLabel.TabIndex = 9;
            this.SyncLabel.Text = "There are unsaved changes.";
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
            this.button4.Text = "Sync with SPARKI";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.SyncButton);
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
            this.profileModeLabel.Size = new System.Drawing.Size(142, 29);
            this.profileModeLabel.TabIndex = 12;
            this.profileModeLabel.Text = "Therapeutic";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 736);
            this.Controls.Add(this.profileModeLabel);
            this.Controls.Add(this.profileNameLabel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.SyncLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.therapeuticTable);
            this.Controls.Add(this.electrodeDropdown);
            this.Controls.Add(this.modeLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.profileLabel);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Name = "Form1";
            this.Text = "S.P.A.R.K.I. Windows Desktop Application";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.therapeuticTable.ResumeLayout(false);
            this.therapeuticTable.PerformLayout();
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
        private System.Windows.Forms.ComboBox electrodeDropdown;
        private System.Windows.Forms.TableLayoutPanel therapeuticTable;
        private System.Windows.Forms.TextBox rampingTimePulseWidthTB;
        private System.Windows.Forms.TextBox freqTB;
        private System.Windows.Forms.TextBox rampingTimeFreqTB;
        private System.Windows.Forms.TextBox pulseWidthTB;
        private System.Windows.Forms.TextBox stimTimeTB;
        private System.Windows.Forms.TextBox rampingTimeAmpTB;
        private System.Windows.Forms.TextBox onTimeTB;
        private System.Windows.Forms.TextBox offTimeTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label SyncLabel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label profileNameLabel;
        private System.Windows.Forms.Label profileModeLabel;
    }
}

