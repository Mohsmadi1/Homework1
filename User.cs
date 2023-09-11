using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadi_task
{
    internal class User
    {

        public void user()
        {
            string[,] users = new string[,]
            {
            { "Shadi", "Shadilios" },
            { "Moa", "Moa@1" },
            { "Faris", "Fsmadi" }
            };

            bool CheckUser = false;
            string inputName = "";
            string inputPass = "";

            while (!CheckUser)
            {
                Console.Write("Please enter your name   ");
                inputName = Console.ReadLine();
                Console.Write("Please enter your password   ");
                inputPass = Console.ReadLine();

                for (int i = 0; i < users.GetLength(0); i++)
                {
                    if (users[i, 0] == inputName && users[i, 1] == inputPass)
                    {
                        CheckUser = true;
                        break;
                    }
                }

                if (!CheckUser)
                {
                    Console.WriteLine("Your name or your password are incorrect");
                }
            }

            switch (inputName)
            {
                case "Shadi":
                    Shadi();
                    break;
                case "Moa":
                    Moa();
                    break;
                case "Faris":
                    Faris();
                    break;
            }
        }
        private void Shadi()
        {
            Employee Shadi = new Employee();

            Shadi.Shadi();

        }

        private void Moa()
        {
            Employee Moa = new Employee();

            Moa.Moa();

        }

        private void Faris()
        {
            Resturant Faris = new Resturant();
            Faris.resturant("Faris");
        }


    }
}
