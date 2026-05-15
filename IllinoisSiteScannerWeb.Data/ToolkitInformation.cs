using System.Text.RegularExpressions;

namespace IllinoisSiteScannerWeb.Data {

    internal static class ToolkitInformation {

        internal static (string oldItem, string newItem) Check(string html) {
            var oldItem = "N/A";
            var newItem = "N/A";
            var matches = Regex.Matches(html, "toolkit.illinois.edu\\/(.*?)\\/toolkit");
            foreach (Match match in matches) {
                if (match.Groups[1].Value.StartsWith("2")) {
                    oldItem = match.Groups[1].Value;
                }
                if (match.Groups[1].Value.StartsWith("3")) {
                    newItem = match.Groups[1].Value;
                }
            }
            return (oldItem, newItem);
        }
    }
}