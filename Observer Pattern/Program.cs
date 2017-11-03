using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    public class Program
    {

        public static void Main(String[] args)
        {
            int option;

            FinanceDepartment fd = new FinanceDepartment();
            HRDepartment hrd = new HRDepartment();

            Employee e = new Employee();

            e.Attach(fd.ReceiveStatus);
            e.Attach(hrd.ReceiveStatus);

            do
            {
                Console.Write("\n\nChoose User's Status");
                Console.WriteLine("\n\n 1. Active");
                Console.WriteLine("\n 2. Unassigned");
                Console.WriteLine("\n 3. Resigned");
                Console.WriteLine("\n 4. Exit");

                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1: e.Status = "Active";
                        break;

                    case 2: e.Status = "Unassigned";
                        break;

                    case 3: e.Status = "Resigned";
                        break;

                    default: break;
                }

            } while (option != 4);

            Console.Read();
        }
    }
}
