namespace Wesley.NotificationContext
{
    public sealed class Notification
    {
        public Notification()
        {
            
        }

        public Notification(string property)
        {
            this.Property = property;
        }

        public Notification(string property, string message)
        {
            this.Property = property;
            this.Message = message;
        }

        public string Property { get; set; }
        public string Message { get; set; }
    }
}