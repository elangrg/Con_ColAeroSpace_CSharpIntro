namespace WinFormIntro
{
    partial class frmContactInfo
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
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.rbtMale = new System.Windows.Forms.RadioButton();
            this.rbtFemale = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbContactnumberType = new System.Windows.Forms.ComboBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.lstQual = new System.Windows.Forms.ListBox();
            this.chkChess = new System.Windows.Forms.CheckBox();
            this.chkMusic = new System.Windows.Forms.CheckBox();
            this.chkMovies = new System.Windows.Forms.CheckBox();
            this.chkTravel = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(788, 104);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(441, 34);
            this.txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(324, 104);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(456, 34);
            this.txtFirstName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(954, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "First";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 482);
            this.label6.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 27);
            this.label6.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 307);
            this.label7.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 27);
            this.label7.TabIndex = 5;
            this.label7.Text = "Gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 671);
            this.label8.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 27);
            this.label8.TabIndex = 6;
            this.label8.Text = "Interests";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 465);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 27);
            this.label5.TabIndex = 7;
            this.label5.Text = "Qualification";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name ";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(324, 164);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAddress.Size = new System.Drawing.Size(905, 114);
            this.txtAddress.TabIndex = 3;
            // 
            // rbtMale
            // 
            this.rbtMale.AutoSize = true;
            this.rbtMale.Location = new System.Drawing.Point(6, 20);
            this.rbtMale.Name = "rbtMale";
            this.rbtMale.Size = new System.Drawing.Size(89, 31);
            this.rbtMale.TabIndex = 10;
            this.rbtMale.TabStop = true;
            this.rbtMale.Text = "Male";
            this.rbtMale.UseVisualStyleBackColor = true;
            // 
            // rbtFemale
            // 
            this.rbtFemale.AutoSize = true;
            this.rbtFemale.Location = new System.Drawing.Point(150, 20);
            this.rbtFemale.Name = "rbtFemale";
            this.rbtFemale.Size = new System.Drawing.Size(117, 31);
            this.rbtFemale.TabIndex = 10;
            this.rbtFemale.TabStop = true;
            this.rbtFemale.Text = "Female";
            this.rbtFemale.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtFemale);
            this.groupBox1.Controls.Add(this.rbtMale);
            this.groupBox1.Location = new System.Drawing.Point(328, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 66);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // cmbContactnumberType
            // 
            this.cmbContactnumberType.FormattingEnabled = true;
            this.cmbContactnumberType.Items.AddRange(new object[] {
            "HOME",
            "OFFICE",
            "MOBILE"});
            this.cmbContactnumberType.Location = new System.Drawing.Point(31, 388);
            this.cmbContactnumberType.Name = "cmbContactnumberType";
            this.cmbContactnumberType.Size = new System.Drawing.Size(269, 35);
            this.cmbContactnumberType.TabIndex = 12;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(324, 389);
            this.txtContactNo.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(905, 34);
            this.txtContactNo.TabIndex = 1;
            // 
            // lstQual
            // 
            this.lstQual.FormattingEnabled = true;
            this.lstQual.ItemHeight = 27;
            this.lstQual.Items.AddRange(new object[] {
            "SSLC",
            "PUC",
            "ME",
            "BE",
            "MA",
            "CA",
            "BCOM",
            "BBM",
            "BCS",
            "BSC"});
            this.lstQual.Location = new System.Drawing.Point(324, 465);
            this.lstQual.Name = "lstQual";
            this.lstQual.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstQual.Size = new System.Drawing.Size(905, 139);
            this.lstQual.TabIndex = 13;
            // 
            // chkChess
            // 
            this.chkChess.AutoSize = true;
            this.chkChess.Location = new System.Drawing.Point(324, 658);
            this.chkChess.Name = "chkChess";
            this.chkChess.Size = new System.Drawing.Size(104, 31);
            this.chkChess.TabIndex = 14;
            this.chkChess.Text = "Chess";
            this.chkChess.UseVisualStyleBackColor = true;
            this.chkChess.CheckedChanged += new System.EventHandler(this.Interest_Changed);
            // 
            // chkMusic
            // 
            this.chkMusic.AutoSize = true;
            this.chkMusic.Location = new System.Drawing.Point(472, 658);
            this.chkMusic.Name = "chkMusic";
            this.chkMusic.Size = new System.Drawing.Size(104, 31);
            this.chkMusic.TabIndex = 14;
            this.chkMusic.Text = "Music";
            this.chkMusic.UseVisualStyleBackColor = true;
            this.chkMusic.CheckedChanged += new System.EventHandler(this.Interest_Changed);
            // 
            // chkMovies
            // 
            this.chkMovies.AutoSize = true;
            this.chkMovies.Location = new System.Drawing.Point(607, 658);
            this.chkMovies.Name = "chkMovies";
            this.chkMovies.Size = new System.Drawing.Size(118, 31);
            this.chkMovies.TabIndex = 14;
            this.chkMovies.Text = "Movies";
            this.chkMovies.UseVisualStyleBackColor = true;
            this.chkMovies.CheckedChanged += new System.EventHandler(this.Interest_Changed);
            // 
            // chkTravel
            // 
            this.chkTravel.AutoSize = true;
            this.chkTravel.Location = new System.Drawing.Point(768, 658);
            this.chkTravel.Name = "chkTravel";
            this.chkTravel.Size = new System.Drawing.Size(160, 31);
            this.chkTravel.TabIndex = 14;
            this.chkTravel.Text = "Traveling";
            this.chkTravel.UseVisualStyleBackColor = true;
            this.chkTravel.CheckedChanged += new System.EventHandler(this.Interest_Changed);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1031, 705);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 43);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmContactInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 760);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkTravel);
            this.Controls.Add(this.chkMovies);
            this.Controls.Add(this.chkMusic);
            this.Controls.Add(this.chkChess);
            this.Controls.Add(this.lstQual);
            this.Controls.Add(this.cmbContactnumberType);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "frmContactInfo";
            this.Text = "frmContactInfo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.RadioButton rbtMale;
        private System.Windows.Forms.RadioButton rbtFemale;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbContactnumberType;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.ListBox lstQual;
        private System.Windows.Forms.CheckBox chkChess;
        private System.Windows.Forms.CheckBox chkMusic;
        private System.Windows.Forms.CheckBox chkMovies;
        private System.Windows.Forms.CheckBox chkTravel;
        private System.Windows.Forms.Button btnSave;
    }
}