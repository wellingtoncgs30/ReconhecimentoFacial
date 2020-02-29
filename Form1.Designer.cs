namespace ReconhecimentoFacial
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelButton = new System.Windows.Forms.Panel();
            this.detect = new System.Windows.Forms.Button();
            this.comboDevice = new System.Windows.Forms.ComboBox();
            this.labelDevice = new System.Windows.Forms.Label();
            this.pictureWebCam = new System.Windows.Forms.PictureBox();
            this.panelButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWebCam)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.detect);
            this.panelButton.Location = new System.Drawing.Point(641, 68);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(108, 216);
            this.panelButton.TabIndex = 0;
            // 
            // detect
            // 
            this.detect.Location = new System.Drawing.Point(0, 0);
            this.detect.Name = "detect";
            this.detect.Size = new System.Drawing.Size(108, 23);
            this.detect.TabIndex = 0;
            this.detect.Text = "Capturar";
            this.detect.UseVisualStyleBackColor = true;
            this.detect.Click += new System.EventHandler(this.Detect_Click);
            // 
            // comboDevice
            // 
            this.comboDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDevice.FormattingEnabled = true;
            this.comboDevice.Location = new System.Drawing.Point(191, 26);
            this.comboDevice.Name = "comboDevice";
            this.comboDevice.Size = new System.Drawing.Size(287, 21);
            this.comboDevice.TabIndex = 1;
            // 
            // labelDevice
            // 
            this.labelDevice.AutoSize = true;
            this.labelDevice.Location = new System.Drawing.Point(124, 29);
            this.labelDevice.Name = "labelDevice";
            this.labelDevice.Size = new System.Drawing.Size(61, 13);
            this.labelDevice.TabIndex = 2;
            this.labelDevice.Text = "Dispositivo:";
            // 
            // pictureWebCam
            // 
            this.pictureWebCam.Location = new System.Drawing.Point(12, 68);
            this.pictureWebCam.Name = "pictureWebCam";
            this.pictureWebCam.Size = new System.Drawing.Size(582, 355);
            this.pictureWebCam.TabIndex = 3;
            this.pictureWebCam.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureWebCam);
            this.Controls.Add(this.labelDevice);
            this.Controls.Add(this.comboDevice);
            this.Controls.Add(this.panelButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reconhecimento facial usando C#";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureWebCam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Button detect;
        private System.Windows.Forms.ComboBox comboDevice;
        private System.Windows.Forms.Label labelDevice;
        private System.Windows.Forms.PictureBox pictureWebCam;
    }
}

