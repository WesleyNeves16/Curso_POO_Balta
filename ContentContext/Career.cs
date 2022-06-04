using System.Collections.Generic;
using Wesley.ContentContext.Enums;

namespace Wesley.ContentContext 
{    
    public class Career: Content
    {
        public Career(string title, string url)
        : base(title, url)
        {
            Items = new List<CareerItem>();
        }
        public IList<CareerItem> Items { get; set; }
        public int TotalCourses => Items.Count; //Expression Body -> removi o get dessa propriedade, pois ele era uma função de uma linha        
    }    
}