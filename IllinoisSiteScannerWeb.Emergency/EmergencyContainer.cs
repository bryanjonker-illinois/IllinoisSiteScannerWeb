namespace IllinoisSiteScannerWeb.Emergency {

    public class EmergencyContainer {
        private readonly Func<Alert> _action;
        private Alert _alert;
        private const int NumberOfSecondsInCache = 30;

        public EmergencyContainer(Func<Alert> action) {
            _action = action;
            _alert = new();
        }

        public Alert Get() {
            if (!_alert.IsSafe || DateTime.Now.Subtract(_alert.LastUpdated).TotalSeconds > NumberOfSecondsInCache) {
                _alert = _action();
            }
            return _alert;
        }
    }
}