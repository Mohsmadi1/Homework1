using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadi_task
{
    internal class Employee
    {

        public void Shadi()
        {

            bool CheckUser = false;
            while (!CheckUser)
            {
                Console.WriteLine("Hello, Director Shadi");
                Console.WriteLine("what would you like to do");
                Console.WriteLine("");
                Console.WriteLine("1 : See the restaurants branches");
                Console.WriteLine("");
                Console.WriteLine("2 : See the restaurant system ");
                Console.WriteLine("");
                string UserChoose = Console.ReadLine();
                switch (UserChoose)
                {
                    case "1":
                        CheckUser = true;
                        Branches maneger = new Branches();

                        Console.WriteLine("");
                        maneger.FirstBranch();
                        Console.WriteLine("");
                        maneger.SecondBranch();
                        Console.WriteLine("");
                        maneger.ThirdBranch();
                        Console.WriteLine("");


                        Console.WriteLine("");
                        Console.WriteLine("Would you like to change something in these restaurants?");
                        Console.WriteLine("");
                        Console.WriteLine("1 : Yes");
                        Console.WriteLine("");
                        Console.WriteLine("2 : No");
                        string UserChoose2 = Console.ReadLine();


                        bool CheckUser2 = false;
                        while (!CheckUser2)
                        {

                            bool CheckUser1 = false;
                            while (!CheckUser1)
                            {
                                switch (UserChoose2)
                                {
                                    case "1":
                                        CheckUser1 = true;
                                        Console.WriteLine("What do you want to change");
                                        Console.WriteLine("");
                                        Console.WriteLine($"1 : branch1Name {maneger.branch1Name}");
                                        Console.WriteLine($"2 : opening1Date {maneger.opening1Date}");
                                        Console.WriteLine($"3 : Branch1Location {maneger.Branch1Location}");
                                        Console.WriteLine($"4 : branch2Name {maneger.branch2Name}");
                                        Console.WriteLine($"5 : opening2Date {maneger.opening2Date}");
                                        Console.WriteLine($"6 : Branch2Location {maneger.Branch2Location}");
                                        Console.WriteLine($"7 : branch3Name {maneger.branch3Name}");
                                        Console.WriteLine($"8 : opening3Date{maneger.opening3Date}");
                                        Console.WriteLine($"9 : Branch3Location {maneger.Branch3Location}");
                                        string UserChoose3 = Console.ReadLine();
                                        Console.WriteLine("");
                                        Console.WriteLine("What do you want to change it to");
                                        string UserChoose4 = Console.ReadLine();
                                        switch (UserChoose3)
                                        {
                                            case "1":
                                                maneger.branch1Name = UserChoose4;
                                                break;
                                            case "2":
                                                maneger.opening1Date = UserChoose4;
                                                break;
                                            case "3":
                                                maneger.Branch1Location = UserChoose4;
                                                break;
                                            case "4":
                                                maneger.branch2Name = UserChoose4;
                                                break;
                                            case "5":
                                                maneger.opening2Date = UserChoose4;
                                                break;
                                            case "6":
                                                maneger.Branch2Location = UserChoose4;
                                                break;
                                            case "7":
                                                maneger.branch3Name = UserChoose4;
                                                break;
                                            case "8":
                                                maneger.opening3Date = UserChoose4;
                                                break;
                                            case "9":
                                                maneger.Branch3Location = UserChoose4;
                                                break;
                                        }

                                        Console.WriteLine("");
                                        maneger.FirstBranch();
                                        Console.WriteLine("");
                                        maneger.SecondBranch();
                                        Console.WriteLine("");
                                        maneger.ThirdBranch();
                                        Console.WriteLine("");

                                        Console.WriteLine("Do you want to change anything else?");
                                        Console.WriteLine("1 : Yes");
                                        Console.WriteLine("2 : No");
                                        string UserChoose5 = Console.ReadLine();
                                        switch (UserChoose5)
                                        {

                                            case "2":
                                                CheckUser2 = true;
                                                break;
                                        }

                                        break;

                                    case "2":
                                        CheckUser = true;

                                        Console.WriteLine("Ok Sir have a good day");

                                        break;

                                }
                                if (!CheckUser1)
                                {
                                    Console.WriteLine("Your Inpot is incorrect");
                                }
                            }
                        }
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        break;
                    case "2":
                        CheckUser = true;
                        Resturant Shadi = new Resturant();
                        Shadi.resturant("Shadi");
                        break;

                }
                if (!CheckUser)
                {
                    Console.WriteLine("Your Inpot is incorrect");
                }
            }
        }

        public void Moa()
        {


            bool CheckUser = false;
            while (!CheckUser)
            {
                Console.WriteLine("Hello, Assistant Director Moa");
                Console.WriteLine("what would you like to do");
                Console.WriteLine("");
                Console.WriteLine("1 : See the restaurants branches");
                Console.WriteLine("");
                Console.WriteLine("2 : See the restaurant system ");
                string UserChoose = Console.ReadLine();
                switch (UserChoose)
                {
                    case "1":
                        CheckUser = true;
                        Branches AssistantDirector = new Branches();

                        Console.WriteLine("");
                        AssistantDirector.FirstBranch();
                        Console.WriteLine("");
                        AssistantDirector.SecondBranch();
                        Console.WriteLine("");
                        AssistantDirector.ThirdBranch();
                        Console.WriteLine("");

                        break;

                    case "2":
                        CheckUser = true;
                        Resturant Moa = new Resturant();
                        Moa.resturant("Moa");
                        break;





                }
            }
        }


    }
}
