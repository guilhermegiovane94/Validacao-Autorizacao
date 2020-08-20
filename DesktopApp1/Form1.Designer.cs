namespace DesktopApp1
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
            this.helloWorldLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNSU = new System.Windows.Forms.TextBox();
            this.txtFULL_NSU = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLOG_PATH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEVIDENCIA_PATH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBREAK_LINE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVALIDAR = new System.Windows.Forms.Button();
            this.btnEVIDENCIA = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbVERSION = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDATA_LOG = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // helloWorldLabel
            // 
            this.helloWorldLabel.AutoSize = true;
            this.helloWorldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloWorldLabel.Location = new System.Drawing.Point(232, 25);
            this.helloWorldLabel.Name = "helloWorldLabel";
            this.helloWorldLabel.Size = new System.Drawing.Size(256, 31);
            this.helloWorldLabel.TabIndex = 3;
            this.helloWorldLabel.Text = "EASY VALIDATION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "NSU";
            // 
            // txtNSU
            // 
            this.txtNSU.Location = new System.Drawing.Point(59, 101);
            this.txtNSU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNSU.Name = "txtNSU";
            this.txtNSU.Size = new System.Drawing.Size(371, 22);
            this.txtNSU.TabIndex = 6;
            this.txtNSU.Text = "441735";
            // 
            // txtFULL_NSU
            // 
            this.txtFULL_NSU.Location = new System.Drawing.Point(59, 155);
            this.txtFULL_NSU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFULL_NSU.Name = "txtFULL_NSU";
            this.txtFULL_NSU.Size = new System.Drawing.Size(371, 22);
            this.txtFULL_NSU.TabIndex = 8;
            this.txtFULL_NSU.Text = "NSU:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "FULL NSU";
            // 
            // txtLOG_PATH
            // 
            this.txtLOG_PATH.Enabled = false;
            this.txtLOG_PATH.Location = new System.Drawing.Point(59, 214);
            this.txtLOG_PATH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLOG_PATH.Name = "txtLOG_PATH";
            this.txtLOG_PATH.Size = new System.Drawing.Size(371, 22);
            this.txtLOG_PATH.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "LOG PATH";
            // 
            // txtEVIDENCIA_PATH
            // 
            this.txtEVIDENCIA_PATH.Enabled = false;
            this.txtEVIDENCIA_PATH.Location = new System.Drawing.Point(59, 272);
            this.txtEVIDENCIA_PATH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEVIDENCIA_PATH.Name = "txtEVIDENCIA_PATH";
            this.txtEVIDENCIA_PATH.Size = new System.Drawing.Size(371, 22);
            this.txtEVIDENCIA_PATH.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "EVIDENCIA PATH";
            // 
            // txtBREAK_LINE
            // 
            this.txtBREAK_LINE.Location = new System.Drawing.Point(59, 326);
            this.txtBREAK_LINE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBREAK_LINE.Name = "txtBREAK_LINE";
            this.txtBREAK_LINE.Size = new System.Drawing.Size(371, 22);
            this.txtBREAK_LINE.TabIndex = 14;
            this.txtBREAK_LINE.Text = "*** ACTR ***";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "BREAK LINE";
            // 
            // btnVALIDAR
            // 
            this.btnVALIDAR.Location = new System.Drawing.Point(504, 271);
            this.btnVALIDAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVALIDAR.Name = "btnVALIDAR";
            this.btnVALIDAR.Size = new System.Drawing.Size(155, 23);
            this.btnVALIDAR.TabIndex = 15;
            this.btnVALIDAR.Text = "VALIDAR";
            this.btnVALIDAR.UseVisualStyleBackColor = true;
            this.btnVALIDAR.Click += new System.EventHandler(this.btnVALIDAR_Click);
            // 
            // btnEVIDENCIA
            // 
            this.btnEVIDENCIA.Location = new System.Drawing.Point(504, 316);
            this.btnEVIDENCIA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEVIDENCIA.Name = "btnEVIDENCIA";
            this.btnEVIDENCIA.Size = new System.Drawing.Size(155, 23);
            this.btnEVIDENCIA.TabIndex = 16;
            this.btnEVIDENCIA.Text = "GERAR EVIDENCIA";
            this.btnEVIDENCIA.UseVisualStyleBackColor = true;
            this.btnEVIDENCIA.Click += new System.EventHandler(this.btnEVIDENCIA_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "DATA LOG";
            // 
            // cmbVERSION
            // 
            this.cmbVERSION.FormattingEnabled = true;
            this.cmbVERSION.Items.AddRange(new object[] {
            "19.2",
            "20.1"});
            this.cmbVERSION.Location = new System.Drawing.Point(59, 448);
            this.cmbVERSION.Margin = new System.Windows.Forms.Padding(4);
            this.cmbVERSION.Name = "cmbVERSION";
            this.cmbVERSION.Size = new System.Drawing.Size(369, 24);
            this.cmbVERSION.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "VERSION";
            // 
            // txtDATA_LOG
            // 
            this.txtDATA_LOG.Location = new System.Drawing.Point(59, 388);
            this.txtDATA_LOG.Mask = "00-00-00";
            this.txtDATA_LOG.Name = "txtDATA_LOG";
            this.txtDATA_LOG.Size = new System.Drawing.Size(369, 22);
            this.txtDATA_LOG.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 596);
            this.Controls.Add(this.txtDATA_LOG);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbVERSION);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEVIDENCIA);
            this.Controls.Add(this.btnVALIDAR);
            this.Controls.Add(this.txtBREAK_LINE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEVIDENCIA_PATH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLOG_PATH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFULL_NSU);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNSU);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.helloWorldLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label helloWorldLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNSU;
        private System.Windows.Forms.TextBox txtFULL_NSU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLOG_PATH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEVIDENCIA_PATH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBREAK_LINE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnVALIDAR;
        private System.Windows.Forms.Button btnEVIDENCIA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbVERSION;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtDATA_LOG;
    }
}

