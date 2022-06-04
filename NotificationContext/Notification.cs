namespace Wesley.NotificationContext
{
    public sealed class Notification
    {
        public Notification()
        {
            
        }

        public Notification(string pr)
        {

        }

        public Notification(string property, string message)
        {
            Property = property;
            Message = message;
        }

        public string Property { get; set; }
        public string Message { get; set; }
    }
}