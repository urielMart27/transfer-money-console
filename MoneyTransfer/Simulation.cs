using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTransfer
{
    internal class Simulation
    {
        public Simulation()
        {
            
        }

        public void RunSimulation()
        {
            Console.WriteLine("Starting simulation");
            //TODO 5: Instantiate two Person objects, with unique names and money amounts. Two lines.
            Person personOne = new Person("Uriel", 500);
            Person PersonTwo = new Person("Peter",100);

            //TODO 6: Call the .DisplayInfo() method on each person object, one at a time. This will show their initial money amount. Two lines.

            personOne.DisplayInfo();
            PersonTwo.DisplayInfo();

            //TEST THE APPLICATION AFTER TODOS 5 AND 6!!

            //TODO 9: Call the .TransferMoney() method on one person object (giver), making sure to pass in the second person object (receiver), and the amount being transfered. One line.
            personOne.TransferMoney(PersonTwo, 50);


            //TODO 10: Call the .DisplayInfo() method on each person object again, showing that each person's balance has changed. Two lines.
            personOne.DisplayInfo();
            PersonTwo.DisplayInfo();

            Console.WriteLine("Simulation complete.");
        }
    }
}
