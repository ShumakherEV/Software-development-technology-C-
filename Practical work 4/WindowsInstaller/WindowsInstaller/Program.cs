using System;

namespace WindowsInstaller
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();

            WindowsBuilder builder = new WindowsBuilder();

            Console.WriteLine("Enter your version of windows: Home|Pro|Enterprise");
            String version = Console.ReadLine();
            
            switch(version.ToLower())
            {
                case "home":
                    director.ConstructWindowsHome(builder);
                    break;
                case "pro":
                    director.ConstructWindowsPro(builder);
                    break;
                case "enterprise":
                    director.ConstructWindowsEnterprise(builder);
                    break;
            }

            Windows windows = builder.GetResult();
            
            Console.WriteLine();
            Console.WriteLine("Installing Windows components:");
            Console.WriteLine();

            if (windows.WindowsHello)
                Console.WriteLine("Windows Hello installed");
            if (windows.DeviceEncryption)
                Console.WriteLine("Device Encryption installed");
            if (windows.InternetProtection)
                Console.WriteLine("Internet Protection installed");
            if (windows.WindowsDefenderAntivirus)
                Console.WriteLine("Windows Defender Antivirus installed");
            if (windows.ParentalControlsAndProtection)
                Console.WriteLine("Parental Controls And Protection installed");
            if (windows.FirewallAndNetworkProtection)
                Console.WriteLine("Firewall And Network Protection installed");
            if (windows.BitLockerDeviceEncryption)
                Console.WriteLine("BitLocker Device Encryption installed");
            if (windows.WindowsInformationProtection)
                Console.WriteLine("Windows Information Protection installed");
            if (windows.AssignedAccess)
                Console.WriteLine("Assigned Access installed");
            if (windows.WindowsDefenderApplicationGuard)
                Console.WriteLine("Windows Defender Application Guard installed");
            if (windows.MicrosoftDefenderAdvancedThreatProtection)
                Console.WriteLine("Microsoft Defender Advanced Threat Protection installed");
        }
    }
}
