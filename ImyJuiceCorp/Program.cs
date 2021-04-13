using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImyJuiceCorp
{
    class Program
    {
        static void Main(string[] args)
        {
            var superUser = "Boss";
            var superPass = "AmTheBossHere";

            Welcome();

            var workers = new List<Employee>();
            int workersCounter = 0;
            var juiceStock = new List<Juice>();
            int juiceCounter = 0;

            Console.WriteLine("Tell me your username: ");
            var user = Console.ReadLine();
            Console.WriteLine("Tell me your password: ");
            var pass = Console.ReadLine();

            if(user == superUser && pass == superPass)
            {
                var super = true;
                while (super)
                {
                    Console.WriteLine("Welcome our Boss, how may we serve you today? Here is our menu: " +
                            "CU ==> Create a user\n UP ==> Update the juice stock\n CJ ==> Create a juice flavor\n" + "MS ==> Make a sale\n" +
                            "PS ==> Pay Salary\n CP ==> Check profit performance.\n DU ==> Delete a user\n LU ==> Logout.");
                    var superChoice = Console.ReadLine();

                    //Dealimg with super user options:

                    if (superChoice == "CU")
                    {
                        Console.WriteLine("What is the full name of the employee? ");
                        var fullNames = Console.ReadLine();
                        Console.WriteLine("What will be his/her username? ");
                        var username = Console.ReadLine();
                        Console.WriteLine("What is his/her Category? ");
                        var category = Console.ReadLine();
                        Console.WriteLine("Create a password for " + fullNames);
                        var password = Console.ReadLine();
                        Console.WriteLine(" How much do you plan to pay " + username + " ?");
                        var pay = float.Parse(Console.ReadLine());

                        //Create the new employee.
                        var newEmployee = new Employee(fullNames, username, category, password, pay);
                        //add the user to the list.
                        workers.Add(newEmployee);
                        workersCounter++;
                        Console.WriteLine("You have successfully added " + fullNames + " And his/ her index is " + (workersCounter - 1));
                    }
                    else if (superChoice == "CJ")
                    {
                        Console.WriteLine("What is the name of the juice? ");
                        var juiceName = Console.ReadLine();
                        Console.WriteLine("Of what flavor is it? ");
                        var flavor = Console.ReadLine();
                        Console.WriteLine("What was the production cost per liter? ");
                        var costs = float.Parse(Console.ReadLine());
                        Console.WriteLine("How much will you sell each unit? ");
                        var salesPrice = float.Parse(Console.ReadLine());
                        Console.WriteLine("How much of " + juiceName + " Was produced today? ");
                        var qtyProduced = float.Parse(Console.ReadLine());

                        //Create a new juice.
                        var newJuice = new Juice(juiceName, flavor, costs, salesPrice, qtyProduced);
                        //Add the juice to the stock.
                        juiceStock.Add(newJuice);
                        juiceCounter++;

                        Console.WriteLine("You successfully Created a juce with a flavor of: " + flavor + " with an indexer of: " + (juiceCounter - 1));
                    }
                        else if (superChoice == "UP")
                    {
                        Console.WriteLine("Enter the index of the juice you want to update:");
                        var juiceIndex = int.Parse(Console.ReadLine());
                        juiceStock.ElementAt(juiceIndex).UpdateQuantity(juiceIndex);

                        }
                        else if (superChoice == "DU")
                    {
                            /*
                        Console.WriteLine("Just tell me the employee index: ");
                        var empIndex = int.Parse(Console.ReadLine());

                        workers.Remove(empIndex);
                            */
                        Console.WriteLine("What is the full name of the employee? ");
                        var fullNames = Console.ReadLine();
                        Console.WriteLine("What was his/her username? ");
                        var username = Console.ReadLine();
                        Console.WriteLine("What is his/her Category? ");
                        var category = Console.ReadLine();
                        Console.WriteLine("What is the password for " + fullNames);
                        var password = Console.ReadLine();
                        Console.WriteLine(" How much were you paying " + username + " ?");
                        var pay = float.Parse(Console.ReadLine());

                        //Create the new employee.
                        var removeEmployee = new Employee(fullNames, username, category, password, pay);
                        //add the user to the list.
                        workers.Remove(removeEmployee);
                        workersCounter--;
                        Console.WriteLine(" You successfully removed " + username);

                        }
                        else if(superChoice == "PS")
                    {
                        Console.WriteLine("What is the employee index? ");
                        var workerIndex = int.Parse(Console.ReadLine());
                        workers.ElementAt(workerIndex).SalaryPay(workerIndex);
                        }
                        else if(superChoice == "MS")
                    {
                        Console.WriteLine("What is the index of the juice you want to sale? ");
                        var juiceIndex = int.Parse(Console.ReadLine());
                        juiceStock.ElementAt(juiceIndex).Sale(juiceIndex);
                        }
                    else
                    {
                        Console.WriteLine(" It seems you entered awrong choice.");
                        super = false;
                    }
                }

                /*
                else if(user == workers.Exists(user) && pass == workers.Exists(pass))
                {

                }
                 */





            }
            else
            {
                Console.WriteLine("Unfortunately, you are not yet registered with us, talk to your boss..");
            }

        }

        static void Welcome()
        {
            Console.WriteLine("Today is: " + DateTime.Now );
            Console.WriteLine(" Welcome to Immy's Juice company, Hopefully you enjoy using me.");
            Console.WriteLine("Let's begin by identifying you: ");

        }
    }
}
