using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsInstaller
{
    /// <summary>
    /// Class describing Windows
    /// </summary>
    class Windows
    {
        public bool WindowsHello { get; set; }
        public bool DeviceEncryption { get; set; }
        public bool InternetProtection { get; set; }
        public bool WindowsDefenderAntivirus { get; set; }
        public bool ParentalControlsAndProtection { get; set; }
        public bool FirewallAndNetworkProtection { get; set; }
        public bool BitLockerDeviceEncryption { get; set; }
        public bool WindowsInformationProtection { get; set; }
        public bool AssignedAccess { get; set; }
        public bool WindowsDefenderApplicationGuard { get; set; }
        public bool MicrosoftDefenderAdvancedThreatProtection { get; set; }

    }
}

+WindowsHello: bool
+DeviceEncryption: bool
+InternetProtection: bool
+WindowsDefenderAntivirus: bool
+ParentalControlsAndProtection: bool
+FirewallAndNetworkProtection: bool
+BitLockerDeviceEncryption: bool
+WindowsInformationProtection: bool
+AssignedAccess: bool
+WindowsDefenderApplicationGuard: bool
+MicrosoftDefenderAdvancedThreatProtection: bool
