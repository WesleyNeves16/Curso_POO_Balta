using System.Collections.Generic;
using Wesley.NotificationContext;

namespace Wesley.ContentContext 
{
    public class Article: Content
    {
        public IList<Notification> Notification { get; set; }
        public Article(string title, string url)
        : base(title, url)
        {
            
        }

    }
}