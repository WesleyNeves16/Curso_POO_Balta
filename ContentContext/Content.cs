using System;

namespace Wesley.ContentContext 
{
    public abstract class Content
    {
        public Content(string title, string url)
        {   
            Id = Guid.NewGuid(); //SPOF -> Single Point Of Failure Id = new Guid();
            Title = title;
            Url = url;
        }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}