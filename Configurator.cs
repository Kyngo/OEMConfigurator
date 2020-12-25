using System;
using Microsoft.Win32;

namespace OEMConfigurator {
	class Configurator {
        private readonly string prefix = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\OEMInformation";

        public string GetOEMRecord(string record) {
			try {
				string recordData = Registry.GetValue(prefix, record, "").ToString();
				return recordData;
            } catch (Exception) {
				return "";
            }
		}

		public void ChangeOEMRecord(string record, string value) {
			Registry.SetValue(prefix, record, value);
		}

		public void RemoveOEMRecord(string record) {
			Registry.SetValue(prefix, record, "");
        }
	}
}
