using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsInstaller
{
    class Director
    {
        public void ConstructWindowsHome(Builder builder)
        {
            builder.Reset();
            builder.SetWindowsHello(true);
            builder.SetDeviceEncryption(true);
            builder.SetInternetProtection(true);
            builder.SetWindowsDefenderAntivirus(true);
            builder.SetParentalControlsAndProtection(true);
            builder.SetFirewallAndNetworkProtection(true);
        }
        public void ConstructWindowsPro(Builder builder)
        {
            builder.Reset();
            builder.SetWindowsHello(true);
            builder.SetDeviceEncryption(true);
            builder.SetInternetProtection(true);
            builder.SetWindowsDefenderAntivirus(true);
            builder.SetParentalControlsAndProtection(true);
            builder.SetFirewallAndNetworkProtection(true);
            builder.SetBitLockerDeviceEncryption(true);
            builder.SetWindowsInformationProtection(true);
            builder.SetAssignedAccess(true);
        }
        public void ConstructWindowsEnterprise(Builder builder)
        {
            builder.Reset();
            builder.SetWindowsHello(true);
            builder.SetDeviceEncryption(true);
            builder.SetInternetProtection(true);
            builder.SetWindowsDefenderAntivirus(true);
            builder.SetParentalControlsAndProtection(true);
            builder.SetFirewallAndNetworkProtection(true);
            builder.SetBitLockerDeviceEncryption(true);
            builder.SetWindowsInformationProtection(true);
            builder.SetAssignedAccess(true);
            builder.SetWindowsDefenderApplicationGuard(true);
            builder.SetMicrosoftDefenderAdvancedThreatProtection(true);
        }
    }
}
