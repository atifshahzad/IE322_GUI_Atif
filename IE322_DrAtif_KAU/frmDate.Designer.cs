namespace IE322_App_KAU
{
    partial class frmDate
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
            this.CldBirth = new System.Windows.Forms.MonthCalendar();
            this.DteAppointment = new System.Windows.Forms.DateTimePicker();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbAppointments = new System.Windows.Forms.ComboBox();
            this.BtnAddAppointment = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CldBirth
            // 
            this.CldBirth.Location = new System.Drawing.Point(79, 106);
            this.CldBirth.Name = "CldBirth";
            this.CldBirth.TabIndex = 0;
            // 
            // DteAppointment
            // 
            this.DteAppointment.Location = new System.Drawing.Point(514, 36);
            this.DteAppointment.Name = "DteAppointment";
            this.DteAppointment.Size = new System.Drawing.Size(200, 20);
            this.DteAppointment.TabIndex = 1;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(136, 43);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(170, 20);
            this.TxtName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // CmbAppointments
            // 
            this.CmbAppointments.FormattingEnabled = true;
            this.CmbAppointments.Location = new System.Drawing.Point(383, 310);
            this.CmbAppointments.Name = "CmbAppointments";
            this.CmbAppointments.Size = new System.Drawing.Size(186, 21);
            this.CmbAppointments.TabIndex = 4;
            // 
            // BtnAddAppointment
            // 
            this.BtnAddAppointment.Location = new System.Drawing.Point(383, 244);
            this.BtnAddAppointment.Name = "BtnAddAppointment";
            this.BtnAddAppointment.Size = new System.Drawing.Size(122, 24);
            this.BtnAddAppointment.TabIndex = 5;
            this.BtnAddAppointment.Text = "Add Appointment";
            this.BtnAddAppointment.UseVisualStyleBackColor = true;
            this.BtnAddAppointment.Click += new System.EventHandler(this.BtnAddAppointment_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select Appointment time:";
            // 
            // frmDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnAddAppointment);
            this.Controls.Add(this.CmbAppointments);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.DteAppointment);
            this.Controls.Add(this.CldBirth);
            this.Name = "frmDate";
            this.Text = "Date";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar CldBirth;
        private System.Windows.Forms.DateTimePicker DteAppointment;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbAppointments;
        private System.Windows.Forms.Button BtnAddAppointment;
        private System.Windows.Forms.Label label2;
    }
}