using System.Collections.Generic;
using System.Linq;
using Wesley.NotificationContext;
using Wesley.SharedContext;

namespace Wesley.SubscriptionContext
{    
    public class Student : Base
    {
        public Student()
        {
              Subscriptions = new List<Subscription>(); 
        }

        public User User { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public IList<Subscription> Subscriptions { get; set; }

        public void CreateSubscription(Subscription subscription)
        {
            if(IsPremium)
            {
                AddNotification(new Notification("Premium", "O aluno já tem assinatura"));
                return;
            }

            Subscriptions.Add(subscription);
        }
        public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);
    }    
}