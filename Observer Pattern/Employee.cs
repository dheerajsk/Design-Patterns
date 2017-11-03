using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    public class Employee : Subject
    {
        public String Name { get; set; }

        public String _Status;

        public String Status
        {
            get { return _Status; }

            set
            {
                _Status = value;
                Console.WriteLine("\n==Status is notified to all departments(Observers)==\n");
                Notify(value);
            }
        }

    }
}
