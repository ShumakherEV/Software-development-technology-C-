using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsInstaller
{
    class Director
    {
        /// <summary>
        /// Build Windows Home
        /// </summary>
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

        /// <summary>
        /// Build Windows Pro
        /// </summary>
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

        /// <summary>
        /// Build Windows Enterprise
        /// </summary>
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
