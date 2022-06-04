using System;
using Wesley.NotificationContext;

namespace Wesley.SharedContext 
{
    public abstract class Base : Notifiable
    {
        public Base()
        {
            this.Id = Guid.NewGuid(); //SPOF -> Single Point Of Failure Id = new Guid();
        }
        
        public Guid Id { get; set; }
    } 
    
}