namespace IllinoisSiteScannerWeb.Data.Web {

    internal static class HostingInformation {

        internal static Dictionary<string, string> HostIpAddress = new() {
            { "18.220.149.166", "cPanel" },
            { "18.160.200.125", "PIE" },
            { "13.59.228.241", "PIE" }
        };

        internal static Dictionary<string, string> HostnameAddress = new() {
            { "web.illinois.edu", "cPanel" },
            { "publish.illinois.edu", "PIE" }
        };

        internal static string Check(string ip, string hostname) => HostIpAddress.TryGetValue(ip, out var valueAddress) ? valueAddress :
            HostnameAddress.TryGetValue(hostname, out var valueHostname) ? valueHostname : "Other";
    }
}