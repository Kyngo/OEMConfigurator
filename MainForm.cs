using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;

namespace OEMConfigurator {
	public partial class MainForm : Form {
		private Configurator cnf = new Configurator();
		private string imgPath = null;
		private string tmpFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\KyngoOEMConfigurator";
		private string oemLogoPath = Environment.GetFolderPath(Environment.SpecialFolder.Windows) + @"\System32\oem.bmp";

		public MainForm() {
			InitializeComponent();
			this.buildContents();
            var reg = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion");
            var currentBuildStr = (string)reg.GetValue("CurrentBuild");
            var currentBuild = int.Parse(currentBuildStr);
            if (currentBuild > 22000)
			{
				MessageBox.Show("You're running Windows 11, which does not make use of the image feature. " +
					"The configuration will be stored, but you won't be able to see the image in the System Properties page.",
					"Important - Please read", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
        }

		private void buildContents() {
			this.txtManufacturer.Text = cnf.GetOEMRecord("Manufacturer");
			this.txtModel.Text = cnf.GetOEMRecord("Model");
			this.txtSupportHours.Text = cnf.GetOEMRecord("SupportHours");
			this.txtSupportPhone.Text = cnf.GetOEMRecord("SupportPhone");
			this.txtSupportURL.Text = cnf.GetOEMRecord("SupportURL");
			string regLogoPath = cnf.GetOEMRecord("Logo");
			if (regLogoPath != "") {
				try {
					if (Directory.Exists(this.tmpFolder) == true) {
						Directory.Delete(this.tmpFolder, true);
					}
					Directory.CreateDirectory(this.tmpFolder);
					if (File.Exists(oemLogoPath) == true) {
						File.Copy(oemLogoPath, tmpFolder + @"\oem.bmp");
					}
				} catch (Exception) {
					MessageBox.Show("An error occurred when reading the current OEM logo!", "Load error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					Application.Exit();
				}
				if (regLogoPath != null && regLogoPath != "") {
					this.loadImage(tmpFolder + @"\oem.bmp", true);
				}
            }
		}

		private void loadImage(string imgPath, bool isFromRegistry) {
			if (File.Exists(imgPath) == true) {
				Bitmap bmp = new Bitmap(imgPath);
				
				imgLogo.Image = bmp;
				btnClearLogo.Enabled = true;
				this.imgPath = ofdImageSelector.FileName;
			} else {
				if (isFromRegistry == true) {
					MessageBox.Show("The specified image does not exist!\n\n" + imgPath, "Image error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				} else {
					MessageBox.Show("The image found in the registry does not exist!", "Image error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
		}

		private void clickBtnChangeImage(object sender, EventArgs e) {
			if (ofdImageSelector.ShowDialog() == DialogResult.OK) {
				this.loadImage(ofdImageSelector.FileName, false);
			}
		}

		private void clickBtnClearImage(object sender, EventArgs e) {
			imgLogo.Image = null;
			imgPath = null;
			btnClearLogo.Enabled = false;
        }

		private void clickBtnApplyChanges(object sender, EventArgs e) {
			bool copyImage = false;
			if (this.imgPath != null) {
				try {
					if (File.Exists(oemLogoPath)) {
						File.Delete(oemLogoPath);
					}
					File.Copy(imgPath, oemLogoPath);
					copyImage = true;
				} catch (Exception) {
					MessageBox.Show("The logo could not be copied to a secure directory! Applying changes WITHOUT it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					copyImage = false;
				}
            }

			cnf.ChangeOEMRecord("Manufacturer", this.txtManufacturer.Text);
			cnf.ChangeOEMRecord("Model", this.txtModel.Text);
			cnf.ChangeOEMRecord("SupportHours", this.txtSupportHours.Text);
			cnf.ChangeOEMRecord("SupportPhone", this.txtSupportPhone.Text);
			cnf.ChangeOEMRecord("SupportURL", this.txtSupportURL.Text);
			if (copyImage == true) {
				cnf.ChangeOEMRecord("Logo", oemLogoPath);
            } else {
				cnf.RemoveOEMRecord("Logo");
            }

			MessageBox.Show("The new settings have been applied!", "OEM Records applied", MessageBoxButtons.OK, MessageBoxIcon.Information);

		}

        private void clickBtnAbout(object sender, EventArgs e) {
			MessageBox.Show("OEMConfigurator\n\nSimple tool to edit the OEM registry entries regarding your computer's brand and OEM specs.\n\nCreated by Kyngo\n\nhttps://github.com/Kyngo/OEMConfigurator", "OEMConfigurator", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

        private void clickBtnGithub(object sender, EventArgs e)
        {
			System.Diagnostics.Process.Start("https://github.com/Kyngo/OEMConfigurator");
        }
    }
}
