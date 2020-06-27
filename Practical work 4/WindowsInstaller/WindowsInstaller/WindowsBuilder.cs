using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsInstaller
{
    /// <summary>
    /// Class building Windows
    /// </summary>
    class WindowsBuilder : Builder
    {
        private Windows windows;

        /// <summary>
        /// Create new Windows
        /// </summary>
        public void Reset()
        {
            windows = new Windows();
        }
        public void SetWindowsHello(bool b)
        {
            windows.WindowsHello = b;
        }
        public void SetDeviceEncryption(bool b)
        {
            windows.DeviceEncryption = b;
        }
        public void SetInternetProtection(bool b)
        {
            windows.InternetProtection = b;
        }
        public void SetWindowsDefenderAntivirus(bool b)
        {
            windows.WindowsDefenderAntivirus = b;
        }
        public void SetParentalControlsAndProtection(bool b)
        {
            windows.ParentalControlsAndProtection = b;
        }
        public void SetFirewallAndNetworkProtection(bool b)
        {
            windows.FirewallAndNetworkProtection = b;
        }
        public void SetBitLockerDeviceEncryption(bool b)
        {
            windows.BitLockerDeviceEncryption = b;
        }
        public void SetWindowsInformationProtection(bool b)
        {
            windows.WindowsInformationProtection = b;
        }
        public void SetAssignedAccess(bool b)
        {
            windows.AssignedAccess = b;
        }
        public void SetWindowsDefenderApplicationGuard(bool b)
        {
            windows.WindowsDefenderApplicationGuard = b;
        }
        public void SetMicrosoftDefenderAdvancedThreatProtection(bool b)
        {
            windows.MicrosoftDefenderAdvancedThreatProtection = b;
        }
        public Windows GetResult()
        {
            return windows;
        }
    }
}
