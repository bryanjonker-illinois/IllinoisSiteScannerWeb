using System.Text.RegularExpressions;

namespace IllinoisSiteScannerWeb.Data {

    internal static class PrimarySiteInformation {

        internal static string Check(string html) {
            var match = Regex.Match(html, "<p class=\"il-primary-unit\">(.*?)</p>");
            if (match.Success) {
                return TagRemover.RemoveTags(match.Groups[1].Value);
            }
            var matchNew = Regex.Match(html, "<a(.*?)slot=\"primary-unit(.*?)>(.*?)</a>");
            if (matchNew.Success) {
                return TagRemover.RemoveTags(matchNew.Groups[3].Value);
            }
            return "Not Listed";
        }

        internal static string CheckSite(string html) {
            var matchNew = Regex.Match(html, "<a(.*?)slot=\"site-name(.*?)>(.*?)</a>");
            if (matchNew.Success) {
                return TagRemover.RemoveTags(matchNew.Groups[3].Value);
            }
            return "Not Listed";
        }
    }
}