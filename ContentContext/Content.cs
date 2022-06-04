using System;
using Wesley.SharedContext;

namespace Wesley.ContentContext 
{
    public abstract class Content : Base
    {
        public Content(string title, string url)
        {               
            Title = title;
            Url = url;
        }        
        public string Title { get; set; }
        public string Url { get; set; }
    }
}