namespace IllinoisSiteScannerWeb.Data.Web {

    internal static class CmsInformation {

        internal static Dictionary<string, string> Cms = new() {
            { "content=\"Drupal", "Drupal" },
            { "content=\"Sitefinity", "Sitefinity" },
            { "wp-content/themes", "Wordpress" },
            { "src=\"/ScriptResource.axd?", "Sitefinity" },
            { "/sitemanager/", "Site Manager" }
        };

        internal static string Check(string html, string ip) {
            foreach (var item in Cms) {
                if (html.Contains(item.Key)) {
                    return item.Value;
                }
            }
            return "Unknown CMS";
        }
    }
}