using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    public class HRDepartment
    {

        public void ReceiveStatus(String Status)
        {
            Console.WriteLine("\nEmployee's status at HR Department : "+Status);
        }
    }
}
