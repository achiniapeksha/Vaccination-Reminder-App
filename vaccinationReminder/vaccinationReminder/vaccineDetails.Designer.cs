namespace vaccinationReminder
{
    partial class vaccineDetails
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.vaccine = new System.Windows.Forms.Label();
            this.sheduleDate = new System.Windows.Forms.DateTimePicker();
            this.givenDate = new System.Windows.Forms.DateTimePicker();
            this.hospital = new System.Windows.Forms.TextBox();
            this.fee = new System.Windows.Forms.TextBox();
            this.note = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblVaccineID = new System.Windows.Forms.Label();
            this.vaccineName = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(109, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vaccine Details";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vaccine :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Shedule Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Given Date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hospital :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fee / Charges :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(61, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Note :";
            // 
            // vaccine
            // 
            this.vaccine.AutoSize = true;
            this.vaccine.Location = new System.Drawing.Point(383, 120);
            this.vaccine.Name = "vaccine";
            this.vaccine.Size = new System.Drawing.Size(46, 17);
            this.vaccine.TabIndex = 7;
            this.vaccine.Text = "label8";
            this.vaccine.Visible = false;
            // 
            // sheduleDate
            // 
            this.sheduleDate.CustomFormat = "yyyy-MM-dd";
            this.sheduleDate.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sheduleDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.sheduleDate.Location = new System.Drawing.Point(255, 165);
            this.sheduleDate.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.sheduleDate.Name = "sheduleDate";
            this.sheduleDate.Size = new System.Drawing.Size(246, 34);
            this.sheduleDate.TabIndex = 8;
            this.sheduleDate.Value = new System.DateTime(2021, 6, 21, 0, 0, 0, 0);
            // 
            // givenDate
            // 
            this.givenDate.CustomFormat = "yyyy-MM-dd";
            this.givenDate.Font = new System.Drawing.Font("Consolas", 13.8F);
            this.givenDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.givenDate.Location = new System.Drawing.Point(255, 211);
            this.givenDate.Name = "givenDate";
            this.givenDate.Size = new System.Drawing.Size(246, 34);
            this.givenDate.TabIndex = 9;
            // 
            // hospital
            // 
            this.hospital.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hospital.Font = new System.Drawing.Font("Consolas", 13.8F);
            this.hospital.Location = new System.Drawing.Point(255, 251);
            this.hospital.Name = "hospital";
            this.hospital.Size = new System.Drawing.Size(246, 34);
            this.hospital.TabIndex = 10;
            // 
            // fee
            // 
            this.fee.Font = new System.Drawing.Font("Consolas", 13.8F);
            this.fee.Location = new System.Drawing.Point(255, 290);
            this.fee.Name = "fee";
            this.fee.Size = new System.Drawing.Size(146, 34);
            this.fee.TabIndex = 11;
            this.fee.Text = "0";
            this.fee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.fee.Click += new System.EventHandler(this.fee_Click);
            // 
            // note
            // 
            this.note.Font = new System.Drawing.Font("Consolas", 13.8F);
            this.note.Location = new System.Drawing.Point(255, 334);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(246, 91);
            this.note.TabIndex = 12;
            this.note.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(380, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 43);
            this.button1.TabIndex = 13;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Consolas", 12F);
            this.button2.Location = new System.Drawing.Point(255, 454);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 43);
            this.button2.TabIndex = 14;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblVaccineID
            // 
            this.lblVaccineID.AutoSize = true;
            this.lblVaccineID.Location = new System.Drawing.Point(331, 122);
            this.lblVaccineID.Name = "lblVaccineID";
            this.lblVaccineID.Size = new System.Drawing.Size(46, 17);
            this.lblVaccineID.TabIndex = 15;
            this.lblVaccineID.Text = "label8";
            this.lblVaccineID.Visible = false;
            this.lblVaccineID.Click += new System.EventHandler(this.lblVaccineID_Click);
            // 
            // vaccineName
            // 
            this.vaccineName.AutoSize = true;
            this.vaccineName.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vaccineName.Location = new System.Drawing.Point(250, 117);
            this.vaccineName.Name = "vaccineName";
            this.vaccineName.Size = new System.Drawing.Size(90, 28);
            this.vaccineName.TabIndex = 16;
            this.vaccineName.Text = "label8";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Consolas", 12F);
            this.button3.Location = new System.Drawing.Point(137, 454);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 43);
            this.button3.TabIndex = 17;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // vaccineDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(204)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(583, 541);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.vaccineName);
            this.Controls.Add(this.lblVaccineID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.note);
            this.Controls.Add(this.fee);
            this.Controls.Add(this.hospital);
            this.Controls.Add(this.givenDate);
            this.Controls.Add(this.sheduleDate);
            this.Controls.Add(this.vaccine);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "vaccineDetails";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vaccineDues";
            this.Load += new System.EventHandler(this.vaccineDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label vaccine;
        private System.Windows.Forms.DateTimePicker sheduleDate;
        private System.Windows.Forms.DateTimePicker givenDate;
        private System.Windows.Forms.TextBox hospital;
        private System.Windows.Forms.TextBox fee;
        private System.Windows.Forms.RichTextBox note;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblVaccineID;
        private System.Windows.Forms.Label vaccineName;
        private System.Windows.Forms.Button button3;

    }
}