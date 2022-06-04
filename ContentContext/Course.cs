using System.Collections.Generic;
using Wesley.ContentContext.Enums;

namespace Wesley.ContentContext 
{
    public class Course: Content
    {
        public Course(string title, string url)
        : base(title, url)
        {
            Modules = new List<Module>(); //Sempre iniciar a lista quando instanciar a classe/objeto
        }
        public string Tag { get; set; }
        public IList<Module> Modules { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }        
}