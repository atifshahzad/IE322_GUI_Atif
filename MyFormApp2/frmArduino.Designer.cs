namespace IE322_App_KAU
{
    partial class frmArduino
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
            this.components = new System.ComponentModel.Container();
            this.srpArduino = new System.IO.Ports.SerialPort(this.components);
            this.btnON = new System.Windows.Forms.Button();
            this.btnOFF = new System.Windows.Forms.Button();
            this.stsArduino = new System.Windows.Forms.StatusStrip();
            this.btnOpenConnection = new System.Windows.Forms.Button();
            this.btnCloseConnection = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // srpArduino
            // 
            this.srpArduino.PortName = "COM5";
            // 
            // btnON
            // 
            this.btnON.Location = new System.Drawing.Point(23, 217);
            this.btnON.Name = "btnON";
            this.btnON.Size = new System.Drawing.Size(88, 44);
            this.btnON.TabIndex = 0;
            this.btnON.Text = "ON";
            this.btnON.UseVisualStyleBackColor = true;
            this.btnON.Click += new System.EventHandler(this.btnON_Click);
            // 
            // btnOFF
            // 
            this.btnOFF.Location = new System.Drawing.Point(117, 217);
            this.btnOFF.Name = "btnOFF";
            this.btnOFF.Size = new System.Drawing.Size(88, 44);
            this.btnOFF.TabIndex = 0;
            this.btnOFF.Text = "OFF";
            this.btnOFF.UseVisualStyleBackColor = true;
            this.btnOFF.Click += new System.EventHandler(this.btnOFF_Click);
            // 
            // stsArduino
            // 
            this.stsArduino.Location = new System.Drawing.Point(0, 428);
            this.stsArduino.Name = "stsArduino";
            this.stsArduino.Size = new System.Drawing.Size(800, 22);
            this.stsArduino.TabIndex = 1;
            this.stsArduino.Text = "statusStrip1";
            // 
            // btnOpenConnection
            // 
            this.btnOpenConnection.Location = new System.Drawing.Point(23, 21);
            this.btnOpenConnection.Name = "btnOpenConnection";
            this.btnOpenConnection.Size = new System.Drawing.Size(114, 56);
            this.btnOpenConnection.TabIndex = 2;
            this.btnOpenConnection.Text = "Open Connection";
            this.btnOpenConnection.UseVisualStyleBackColor = true;
            this.btnOpenConnection.Click += new System.EventHandler(this.btnOpenConnection_Click);
            // 
            // btnCloseConnection
            // 
            this.btnCloseConnection.Location = new System.Drawing.Point(154, 21);
            this.btnCloseConnection.Name = "btnCloseConnection";
            this.btnCloseConnection.Size = new System.Drawing.Size(110, 56);
            this.btnCloseConnection.TabIndex = 3;
            this.btnCloseConnection.Text = "Close Connection";
            this.btnCloseConnection.UseVisualStyleBackColor = true;
            this.btnCloseConnection.Click += new System.EventHandler(this.btnCloseConnection_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(671, 377);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // frmArduino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCloseConnection);
            this.Controls.Add(this.btnOpenConnection);
            this.Controls.Add(this.stsArduino);
            this.Controls.Add(this.btnOFF);
            this.Controls.Add(this.btnON);
            this.Name = "frmArduino";
            this.Text = "Arduino";
            this.Load += new System.EventHandler(this.frmArduino_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort srpArduino;
        private System.Windows.Forms.Button btnON;
        private System.Windows.Forms.Button btnOFF;
        private System.Windows.Forms.StatusStrip stsArduino;
        private System.Windows.Forms.Button btnOpenConnection;
        private System.Windows.Forms.Button btnCloseConnection;
        private System.Windows.Forms.Button btnBack;
    }
}