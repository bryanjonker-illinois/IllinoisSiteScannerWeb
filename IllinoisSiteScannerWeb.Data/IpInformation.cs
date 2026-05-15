namespace IllinoisSiteScannerWeb.Data {

    internal static class IpInformation {

        internal static Dictionary<string, string> Hosts = new() {
            { "18.220.149.166", "cPanel" },
            { "18.160.200.125", "PIE" }
        };

        internal static string Check(string ip, string hostname) => Hosts.ContainsKey(ip) ? Hosts[ip] : hostname == "publish.illinois.edu" ? "PIE" : "Other";
    }
}