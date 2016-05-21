namespace Projekt_Teleinf
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
            this.tbMsg = new System.Windows.Forms.TextBox();
            this.cmbCRC = new System.Windows.Forms.ComboBox();
            this.crclabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblHashSumm = new System.Windows.Forms.Label();
            this.tb_CRC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Message_and_CRC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Hammings_code = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nupd_first_error = new System.Windows.Forms.NumericUpDown();
            this.btnRecalc = new System.Windows.Forms.Button();
            this.tb_Decoded_Message_and_CRC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_Hamming_after_checking = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_Hammings_with_errors = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_crc_end = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_Binary_message = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_syndrome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_error_syndrome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nupd_second_error = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nupd_first_error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupd_second_error)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMsg
            // 
            this.tbMsg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMsg.CausesValidation = false;
            this.tbMsg.Location = new System.Drawing.Point(67, 32);
            this.tbMsg.Multiline = true;
            this.tbMsg.Name = "tbMsg";
            this.tbMsg.Size = new System.Drawing.Size(557, 25);
            this.tbMsg.TabIndex = 0;
            this.tbMsg.Tag = "";
            // 
            // cmbCRC
            // 
            this.cmbCRC.FormattingEnabled = true;
            this.cmbCRC.Items.AddRange(new object[] {
            "16",
            "32"});
            this.cmbCRC.Location = new System.Drawing.Point(12, 34);
            this.cmbCRC.Name = "cmbCRC";
            this.cmbCRC.Size = new System.Drawing.Size(40, 21);
            this.cmbCRC.TabIndex = 1;
            this.cmbCRC.SelectedIndexChanged += new System.EventHandler(this.cmbCRC_SelectedIndexChanged);
            // 
            // crclabel
            // 
            this.crclabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crclabel.AutoSize = true;
            this.crclabel.Location = new System.Drawing.Point(15, 15);
            this.crclabel.Name = "crclabel";
            this.crclabel.Size = new System.Drawing.Size(32, 13);
            this.crclabel.TabIndex = 2;
            this.crclabel.Text = "CRC:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Message:";
            // 
            // btnCalc
            // 
            this.btnCalc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalc.Location = new System.Drawing.Point(630, 32);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblHashSumm
            // 
            this.lblHashSumm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHashSumm.AutoSize = true;
            this.lblHashSumm.Location = new System.Drawing.Point(15, 131);
            this.lblHashSumm.Name = "lblHashSumm";
            this.lblHashSumm.Size = new System.Drawing.Size(64, 13);
            this.lblHashSumm.TabIndex = 5;
            this.lblHashSumm.Text = "HashSumm:";
            // 
            // tb_CRC
            // 
            this.tb_CRC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_CRC.Location = new System.Drawing.Point(12, 148);
            this.tb_CRC.Multiline = true;
            this.tb_CRC.Name = "tb_CRC";
            this.tb_CRC.ReadOnly = true;
            this.tb_CRC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_CRC.Size = new System.Drawing.Size(693, 25);
            this.tb_CRC.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Message+HashSumm:";
            // 
            // tb_Message_and_CRC
            // 
            this.tb_Message_and_CRC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Message_and_CRC.Location = new System.Drawing.Point(12, 200);
            this.tb_Message_and_CRC.Multiline = true;
            this.tb_Message_and_CRC.Name = "tb_Message_and_CRC";
            this.tb_Message_and_CRC.ReadOnly = true;
            this.tb_Message_and_CRC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Message_and_CRC.Size = new System.Drawing.Size(693, 25);
            this.tb_Message_and_CRC.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hamming\'s code:";
            // 
            // tb_Hammings_code
            // 
            this.tb_Hammings_code.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Hammings_code.Location = new System.Drawing.Point(12, 253);
            this.tb_Hammings_code.Multiline = true;
            this.tb_Hammings_code.Name = "tb_Hammings_code";
            this.tb_Hammings_code.ReadOnly = true;
            this.tb_Hammings_code.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Hammings_code.Size = new System.Drawing.Size(532, 25);
            this.tb_Hammings_code.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Error position:";
            // 
            // nupd_first_error
            // 
            this.nupd_first_error.Location = new System.Drawing.Point(91, 297);
            this.nupd_first_error.Name = "nupd_first_error";
            this.nupd_first_error.Size = new System.Drawing.Size(41, 20);
            this.nupd_first_error.TabIndex = 18;
            // 
            // btnRecalc
            // 
            this.btnRecalc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecalc.Location = new System.Drawing.Point(630, 294);
            this.btnRecalc.Name = "btnRecalc";
            this.btnRecalc.Size = new System.Drawing.Size(75, 23);
            this.btnRecalc.TabIndex = 21;
            this.btnRecalc.Text = "Recalculate";
            this.btnRecalc.UseVisualStyleBackColor = true;
            this.btnRecalc.Click += new System.EventHandler(this.btnRecalc_Click);
            // 
            // tb_Decoded_Message_and_CRC
            // 
            this.tb_Decoded_Message_and_CRC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Decoded_Message_and_CRC.Location = new System.Drawing.Point(12, 457);
            this.tb_Decoded_Message_and_CRC.Multiline = true;
            this.tb_Decoded_Message_and_CRC.Name = "tb_Decoded_Message_and_CRC";
            this.tb_Decoded_Message_and_CRC.ReadOnly = true;
            this.tb_Decoded_Message_and_CRC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Decoded_Message_and_CRC.Size = new System.Drawing.Size(693, 25);
            this.tb_Decoded_Message_and_CRC.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 441);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Decoded Message+HashSumm:";
            // 
            // tb_Hamming_after_checking
            // 
            this.tb_Hamming_after_checking.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Hamming_after_checking.Location = new System.Drawing.Point(12, 404);
            this.tb_Hamming_after_checking.Multiline = true;
            this.tb_Hamming_after_checking.Name = "tb_Hamming_after_checking";
            this.tb_Hamming_after_checking.ReadOnly = true;
            this.tb_Hamming_after_checking.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Hamming_after_checking.Size = new System.Drawing.Size(693, 25);
            this.tb_Hamming_after_checking.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 388);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Hamming\'s code after cheking:";
            // 
            // tb_Hammings_with_errors
            // 
            this.tb_Hammings_with_errors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Hammings_with_errors.Location = new System.Drawing.Point(12, 352);
            this.tb_Hammings_with_errors.Multiline = true;
            this.tb_Hammings_with_errors.Name = "tb_Hammings_with_errors";
            this.tb_Hammings_with_errors.ReadOnly = true;
            this.tb_Hammings_with_errors.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Hammings_with_errors.Size = new System.Drawing.Size(532, 25);
            this.tb_Hammings_with_errors.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 335);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Hamming\'s code with errors:";
            // 
            // tb_crc_end
            // 
            this.tb_crc_end.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_crc_end.Location = new System.Drawing.Point(12, 509);
            this.tb_crc_end.Multiline = true;
            this.tb_crc_end.Name = "tb_crc_end";
            this.tb_crc_end.ReadOnly = true;
            this.tb_crc_end.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_crc_end.Size = new System.Drawing.Size(693, 25);
            this.tb_crc_end.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 493);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Decoded HashSumm:";
            // 
            // tb_Binary_message
            // 
            this.tb_Binary_message.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Binary_message.Location = new System.Drawing.Point(12, 94);
            this.tb_Binary_message.Multiline = true;
            this.tb_Binary_message.Name = "tb_Binary_message";
            this.tb_Binary_message.ReadOnly = true;
            this.tb_Binary_message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Binary_message.Size = new System.Drawing.Size(693, 25);
            this.tb_Binary_message.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Message in binary form:";
            // 
            // tb_syndrome
            // 
            this.tb_syndrome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_syndrome.Location = new System.Drawing.Point(550, 253);
            this.tb_syndrome.Multiline = true;
            this.tb_syndrome.Name = "tb_syndrome";
            this.tb_syndrome.ReadOnly = true;
            this.tb_syndrome.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_syndrome.Size = new System.Drawing.Size(155, 25);
            this.tb_syndrome.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(547, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Control bits(Syndrome):";
            // 
            // tb_error_syndrome
            // 
            this.tb_error_syndrome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_error_syndrome.Location = new System.Drawing.Point(550, 352);
            this.tb_error_syndrome.Multiline = true;
            this.tb_error_syndrome.Name = "tb_error_syndrome";
            this.tb_error_syndrome.ReadOnly = true;
            this.tb_error_syndrome.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_error_syndrome.Size = new System.Drawing.Size(155, 25);
            this.tb_error_syndrome.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(547, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Control bits(Syndrome):";
            // 
            // nupd_second_error
            // 
            this.nupd_second_error.Location = new System.Drawing.Point(138, 297);
            this.nupd_second_error.Name = "nupd_second_error";
            this.nupd_second_error.Size = new System.Drawing.Size(41, 20);
            this.nupd_second_error.TabIndex = 37;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 555);
            this.Controls.Add(this.nupd_second_error);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_error_syndrome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_syndrome);
            this.Controls.Add(this.tb_Binary_message);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tb_crc_end);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_Decoded_Message_and_CRC);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_Hamming_after_checking);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_Hammings_with_errors);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnRecalc);
            this.Controls.Add(this.nupd_first_error);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_Hammings_code);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Message_and_CRC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_CRC);
            this.Controls.Add(this.lblHashSumm);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crclabel);
            this.Controls.Add(this.cmbCRC);
            this.Controls.Add(this.tbMsg);
            this.Name = "Form1";
            this.Text = "Hamming coding -  Bodia proj.";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupd_first_error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupd_second_error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMsg;
        private System.Windows.Forms.ComboBox cmbCRC;
        private System.Windows.Forms.Label crclabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblHashSumm;
        private System.Windows.Forms.TextBox tb_CRC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Message_and_CRC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Hammings_code;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nupd_first_error;
        private System.Windows.Forms.Button btnRecalc;
        private System.Windows.Forms.TextBox tb_Decoded_Message_and_CRC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_Hamming_after_checking;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_Hammings_with_errors;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_crc_end;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_Binary_message;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_syndrome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_error_syndrome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nupd_second_error;
    }
}

