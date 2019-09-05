using ResponsabilityChain.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsabilityChain
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup Chain of Responsibility

            Approver larry = new Director();
            Approver sam = new VicePresident();
            Approver tammy = new President();
            Approver July = new Chairperson();

            larry.SetSuccessor(sam);
            sam.SetSuccessor(July);
            July.SetSuccessor(tammy);

            // Generate and process purchase requests

            Purchase purchase1 = new Purchase(2034, 5000.00, "Assets");
            larry.ProcessRequest(purchase1);

            Purchase purchase2 = new Purchase(2035, 20000.00, "Keyboard");
            larry.ProcessRequest(purchase2);

            Purchase purchase3 = new Purchase(2036, 30000.00, "Mouse");
            larry.ProcessRequest(purchase3);

            Purchase purchase4 = new Purchase(2037, 90000.00, "CPU");
            larry.ProcessRequest(purchase4);

            Purchase purchase5 = new Purchase(2038, 600000.00, "GPU");
            larry.ProcessRequest(purchase5);

            // Wait for user

            Console.ReadKey();
        }
    }
}
