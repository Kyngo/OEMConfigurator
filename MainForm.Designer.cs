
namespace OEMConfigurator
{
	partial class MainForm
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.ofdImageSelector = new System.Windows.Forms.OpenFileDialog();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtSupportHours = new System.Windows.Forms.TextBox();
            this.txtSupportPhone = new System.Windows.Forms.TextBox();
            this.txtSupportURL = new System.Windows.Forms.TextBox();
            this.btnChangeImage = new System.Windows.Forms.Button();
            this.btnApplyChanges = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnClearLogo = new System.Windows.Forms.Button();
            this.btnGithub = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manufacturer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Support Hours";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Support Phone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Logo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Support URL";
            // 
            // imgLogo
            // 
            this.imgLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgLogo.Location = new System.Drawing.Point(76, 162);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(80, 80);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 9;
            this.imgLogo.TabStop = false;
            // 
            // ofdImageSelector
            // 
            this.ofdImageSelector.Filter = "Bitmap (*.bmp)|*.bmp";
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(96, 12);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(195, 20);
            this.txtManufacturer.TabIndex = 10;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(96, 43);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(195, 20);
            this.txtModel.TabIndex = 11;
            // 
            // txtSupportHours
            // 
            this.txtSupportHours.Location = new System.Drawing.Point(96, 74);
            this.txtSupportHours.Name = "txtSupportHours";
            this.txtSupportHours.Size = new System.Drawing.Size(195, 20);
            this.txtSupportHours.TabIndex = 12;
            // 
            // txtSupportPhone
            // 
            this.txtSupportPhone.Location = new System.Drawing.Point(96, 103);
            this.txtSupportPhone.Name = "txtSupportPhone";
            this.txtSupportPhone.Size = new System.Drawing.Size(195, 20);
            this.txtSupportPhone.TabIndex = 13;
            // 
            // txtSupportURL
            // 
            this.txtSupportURL.Location = new System.Drawing.Point(96, 134);
            this.txtSupportURL.Name = "txtSupportURL";
            this.txtSupportURL.Size = new System.Drawing.Size(195, 20);
            this.txtSupportURL.TabIndex = 14;
            // 
            // btnChangeImage
            // 
            this.btnChangeImage.Location = new System.Drawing.Point(163, 161);
            this.btnChangeImage.Name = "btnChangeImage";
            this.btnChangeImage.Size = new System.Drawing.Size(128, 23);
            this.btnChangeImage.TabIndex = 15;
            this.btnChangeImage.Text = "Change Image";
            this.btnChangeImage.UseVisualStyleBackColor = true;
            this.btnChangeImage.Click += new System.EventHandler(this.clickBtnChangeImage);
            // 
            // btnApplyChanges
            // 
            this.btnApplyChanges.Location = new System.Drawing.Point(163, 219);
            this.btnApplyChanges.Name = "btnApplyChanges";
            this.btnApplyChanges.Size = new System.Drawing.Size(128, 23);
            this.btnApplyChanges.TabIndex = 16;
            this.btnApplyChanges.Text = "Apply Changes";
            this.btnApplyChanges.UseVisualStyleBackColor = true;
            this.btnApplyChanges.Click += new System.EventHandler(this.clickBtnApplyChanges);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(12, 190);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(55, 23);
            this.btnAbout.TabIndex = 17;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.clickBtnAbout);
            // 
            // btnClearLogo
            // 
            this.btnClearLogo.Enabled = false;
            this.btnClearLogo.Location = new System.Drawing.Point(163, 190);
            this.btnClearLogo.Name = "btnClearLogo";
            this.btnClearLogo.Size = new System.Drawing.Size(128, 23);
            this.btnClearLogo.TabIndex = 18;
            this.btnClearLogo.Text = "Clear Logo";
            this.btnClearLogo.UseVisualStyleBackColor = true;
            this.btnClearLogo.Click += new System.EventHandler(this.clickBtnClearImage);
            // 
            // btnGithub
            // 
            this.btnGithub.Location = new System.Drawing.Point(12, 219);
            this.btnGithub.Name = "btnGithub";
            this.btnGithub.Size = new System.Drawing.Size(55, 23);
            this.btnGithub.TabIndex = 19;
            this.btnGithub.Text = "GitHub";
            this.btnGithub.UseVisualStyleBackColor = true;
            this.btnGithub.Click += new System.EventHandler(this.clickBtnGithub);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 254);
            this.Controls.Add(this.btnGithub);
            this.Controls.Add(this.btnClearLogo);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnApplyChanges);
            this.Controls.Add(this.btnChangeImage);
            this.Controls.Add(this.txtSupportURL);
            this.Controls.Add(this.txtSupportPhone);
            this.Controls.Add(this.txtSupportHours);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OEM Configurator";
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.PictureBox imgLogo;
		private System.Windows.Forms.OpenFileDialog ofdImageSelector;
		private System.Windows.Forms.TextBox txtManufacturer;
		private System.Windows.Forms.TextBox txtModel;
		private System.Windows.Forms.TextBox txtSupportHours;
		private System.Windows.Forms.TextBox txtSupportPhone;
		private System.Windows.Forms.TextBox txtSupportURL;
		private System.Windows.Forms.Button btnChangeImage;
		private System.Windows.Forms.Button btnApplyChanges;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnClearLogo;
        private System.Windows.Forms.Button btnGithub;
    }
}

