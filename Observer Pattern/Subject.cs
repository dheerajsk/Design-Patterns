using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{

    public delegate void Observer(String Status);

    public abstract class Subject
    {

        public event Observer ObserverEvent;

        public void Attach(Observer ob)
        {
            ObserverEvent += ob;
        }

        public void Detach(Observer ob)
        {
            ObserverEvent -= ob;
        }


        public void Notify(String Status)
        {
            if (ObserverEvent != null)
            {
                ObserverEvent(Status);
            }
        }

    }
}

