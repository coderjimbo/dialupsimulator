using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace DialUpSimulator
{
    static class Utilities
    {
        public static void DisableActiveNetwork()
        {
            if (AbleToControlNetwork())
            {
                SelectQuery wmiQuery = new SelectQuery("SELECT * FROM Win32_NetworkAdapter WHERE NetConnectionId != NULL");
                ManagementObjectSearcher searchProcedure = new ManagementObjectSearcher(wmiQuery);
                foreach (ManagementObject item in searchProcedure.Get())
                {
                    if (((string)item["NetConnectionId"]) == (string)Properties.Settings.Default["deviceToControl"])
                    {
                        item.InvokeMethod("Disable", null);
                    }
                }
            }

        }

        public static void EnableActiveNetwork()
        {
            if (AbleToControlNetwork())
            {
                SelectQuery wmiQuery = new SelectQuery("SELECT * FROM Win32_NetworkAdapter WHERE NetConnectionId != NULL");
                ManagementObjectSearcher searchProcedure = new ManagementObjectSearcher(wmiQuery);
                foreach (ManagementObject item in searchProcedure.Get())
                {
                    if (((string)item["NetConnectionId"]) == (string)Properties.Settings.Default["deviceToControl"])
                    {
                        item.InvokeMethod("Enable", null);
                    }
                }
            }
        }

        private static bool AbleToControlNetwork()
        {
            return (bool)Properties.Settings.Default["controlDevice"] && Properties.Settings.Default["deviceToControl"] != null && (string)Properties.Settings.Default["deviceToControl"] != "";
        }

        public static bool IsFirstRun()
        {
            return !(bool)Properties.Settings.Default["hasOpenedApplication"];
        }

        public static string GetNetworkAdapterSpeed()
        {
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in adapters)
            {
                if (adapter.Name == (string)Properties.Settings.Default["deviceToControl"])
                {
                    return (adapter.Speed / 1000000) + " Mbps";
                }
            }
            return "N/A";
        }
    }
}
