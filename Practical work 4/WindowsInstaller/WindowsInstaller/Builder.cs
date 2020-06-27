using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsInstaller
{
    public interface Builder
    {
        public void Reset();
        public void SetWindowsHello(bool b);
        public void SetDeviceEncryption(bool b);
        public void SetInternetProtection(bool b);
        public void SetWindowsDefenderAntivirus(bool b);
        public void SetParentalControlsAndProtection(bool b);
        public void SetFirewallAndNetworkProtection(bool b);
        public void SetBitLockerDeviceEncryption(bool b);
        public void SetWindowsInformationProtection(bool b);
        public void SetAssignedAccess(bool b);
        public void SetWindowsDefenderApplicationGuard(bool b);
        public void SetMicrosoftDefenderAdvancedThreatProtection(bool b);
    }
}
