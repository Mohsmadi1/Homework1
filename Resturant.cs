using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadi_task
{
    internal class Resturant
    {
        public Resturant()
        {

        }
        public Resturant(string branchName, string openingDate, string BranchLocation)
        {

            Console.WriteLine($"branch Name {branchName}");
            Console.WriteLine($"opening Date {openingDate}");
            Console.WriteLine($"Branch Location {BranchLocation}");

        }




        // Food 
        private string Food = "Food";
        private string FirstFoodMenu = "Shawarma";
        private string SecondFoodMenu = "Pizza";
        private string ThirdFoodMenu = "Burger";
        private string FFM1 = "Chicken shawarma meal";
        private string FFM2 = "Meat shawarma meal";
        private string FFM3 = "Beef shawarma sandwich";
        private string FFM4 = "Chicken shawarma sandwich";
        private string SFM1 = "Margherita Pizza";
        private string SFM2 = "Pepperoni Pizza";
        private string SFM3 = "Hawaiian Pizza";
        private string SFM4 = "BBQ Chicken Pizza";
        private string TFM1 = "Cheeseburger";
        private string TFM2 = "Bacon Burger";
        private string TFM3 = "Mushroom Swiss Burger";
        private string TFM4 = "BBQ Burger";
        //Desert
        private string Desert = "Desert";
        private string FirstDesertMenu = "waffle";
        private string SecondDesertMenu = "Ice cream";
        private string ThirdDesertMenu = "Milkshake";
        private string FourthDesertMenu = "cheese cake";
        private string FifthDesertMenu = "cake";
        private string FirstDM1 = "Strawberry Waffle";
        private string FirstDM2 = "Chocolate Hazelnut Waffle";
        private string FirstDM3 = "Mixed Fruit Waffle";
        private string SecondDM1 = "Vanilla Ice Cream";
        private string SecondDM2 = "Strawberry Ice Cream";
        private string SecondDM3 = "Chocolate Ice Cream";
        private string ThirdDM1 = "Strawberry Milkshake";
        private string ThirdDM2 = "Chocolate Milkshake";
        private string ThirdDM3 = "Hazelnut Milkshake";
        private string FourthDM1 = "Berry Cheesecake";
        private string FourthDM2 = "Chocolate Cheesecake";
        private string FourthDM3 = "Lemon Cheesecake";
        private string FifthDM1 = "Chocolate Cake";
        private string FifthDM2 = "Carrot Cake";
        private string FifthDM3 = "Vanilla Cake";
        //Juices
        private string Juices = "Juices";
        private string J1 = "Orange Juice";
        private string J2 = "Apple Juice";
        private string J3 = "Grape Juice";
        private string J4 = "Blueberry Juice";
        private string J5 = "Watermelon Juice";
        private string J6 = "Cola";
        private string J7 = "7UP";
        private string J8 = "Pepsi";
        private string J9 = "Miranda";

        public void resturant(string userName)
        {

            bool CheckUser1 = false;
            while (!CheckUser1)
            {
                Console.WriteLine("");
                Console.WriteLine($"Hello{userName} , Welcome to our resturant ");
                Console.WriteLine("");
                Console.WriteLine("What would you like to order?");
                Console.WriteLine("1 : Food ");
                Console.WriteLine("2 : Dessert");
                Console.WriteLine("3 : Juices");
                string userChoose = Console.ReadLine();

                switch (userChoose)
                {
                    case "1":
                        food();
                        CheckUser1 = true;
                        break;
                    case "2":
                        desert();
                        CheckUser1 = true;
                        break;
                    case "3":
                        CheckUser1 = true;
                        juices();
                        break;
                }

                if (!CheckUser1)
                {
                    Console.WriteLine("Your Inpot is incorrect");
                }
            }
        }

        public void food()
        {
            bool CheckUser = false;
            while (!CheckUser)
            {
                Console.WriteLine($"In the {Food} section we have 3 main dishes");

                Console.WriteLine($"1 : {FirstFoodMenu}");
                Console.WriteLine($"2 : {SecondFoodMenu}");
                Console.WriteLine($"3 : {ThirdFoodMenu}");
                Console.WriteLine("");
                string userChoose = Console.ReadLine();

                switch (userChoose)
                {
                    case "1":
                        CheckUser = true;
                        FirstFoodmenu();
                        break;
                    case "2":
                        CheckUser = true;
                        SecondFoodmenu();
                        break;
                    case "3":
                        CheckUser = true;
                        ThirdFoodmenu();
                        break;
                }





                if (!CheckUser)
                {
                    Console.WriteLine("Your Inpot is incorrect");
                }
            }

        }
        public void FirstFoodmenu()
        {
            bool CheckUser = false;
            while (!CheckUser)
            {
                Console.WriteLine($"Our {FirstFoodMenu} are divided into Four categories");

                Console.WriteLine("We have");
                Console.WriteLine($"1 : {FFM1}");
                Console.WriteLine($"2 : {FFM2}");
                Console.WriteLine($"3 : {FFM3}");
                Console.WriteLine($"4 : {FFM4}");

                string FoodShoose = Console.ReadLine();

                switch (FoodShoose)
                {
                    case "1":
                        CheckUser = true;
                        Console.WriteLine($"We will bring you your meal : {FFM1} as soon as possible");
                        break;
                    case "2":
                        CheckUser = true;
                        Console.WriteLine($"We will bring you your meal : {FFM2} as soon as possible");
                        break;
                    case "3":
                        CheckUser = true;
                        Console.WriteLine($"We will bring you your meal : {FFM3} as soon as possible");
                        break;
                    case "4":
                        CheckUser = true;
                        Console.WriteLine($"We will bring you your meal : {FFM4} as soon as possible");
                        break;
                }
            }
            bool CheckUser1 = false;
            while (!CheckUser1)
            {
                Console.WriteLine("Do you want desert with your order");


                Console.WriteLine("1 : yes ");
                Console.WriteLine("2 : No");

                string DesertChoose = Console.ReadLine();

                switch (DesertChoose)
                {
                    case "1":
                        CheckUser1 = true;
                        desert();
                        break;
                    case "2":
                        CheckUser1 = true;
                        bool CheckUser2 = false;
                        while (!CheckUser2)
                        {
                            Console.WriteLine("Okay sir, would you like a drink with your meal?");
                            Console.WriteLine("1 : yes ");
                            Console.WriteLine("2 : No");
                            string juicesChoose = Console.ReadLine();
                            switch (juicesChoose)
                            {
                                case "1":
                                    CheckUser2 = true;
                                    juices();
                                    break;
                                case "2":
                                    CheckUser2 = true;
                                    Console.WriteLine("Ok Sir have a good day");
                                    break;
                            }
                            break;

                            if (!CheckUser2)
                            {
                                Console.WriteLine("Your Inpot is incorrect");
                            }
                        }
                        if (!CheckUser1)
                        {
                            Console.WriteLine("Your Inpot is incorrect");
                        }
                        break;
                }


            }


            if (!CheckUser)
            {
                Console.WriteLine("Your Inpot is incorrect");
            }
        }

        public void SecondFoodmenu()
        {
            bool CheckUser1 = false;
            while (!CheckUser1)
            {
                Console.WriteLine($"Our {SecondFoodMenu} are divided into Four categories");

                Console.WriteLine("We have");
                Console.WriteLine($"1 : {SFM1}");
                Console.WriteLine($"2 : {SFM2}");
                Console.WriteLine($"3 : {SFM3}");
                Console.WriteLine($"4 : {SFM4}");
                string FoodShoose = Console.ReadLine();

                switch (FoodShoose)
                {
                    case "1":
                        CheckUser1 = true;
                        Console.WriteLine($"We will bring you your meal : {SFM1} as soon as possible");
                        break;
                    case "2":
                        CheckUser1 = true;
                        Console.WriteLine($"We will bring you your meal : {SFM2} as soon as possible");
                        break;
                    case "3":
                        CheckUser1 = true;
                        Console.WriteLine($"We will bring you your meal : {SFM3} as soon as possible");
                        break;
                    case "4":
                        CheckUser1 = true;
                        Console.WriteLine($"We will bring you your meal : {SFM4} as soon as possible");
                        break;
                }
                if (!CheckUser1)
                {
                    Console.WriteLine("Your Inpot is incorrect");
                }
            }

            bool CheckUser2 = false;
            while (!CheckUser2)
            {
                Console.WriteLine("Do you want desert with your order");

                Console.WriteLine("1 : yes ");
                Console.WriteLine("2 : No");

                string DesertChoose = Console.ReadLine();

                switch (DesertChoose)
                {
                    case "1":
                        CheckUser2 = true;
                        desert();
                        break;
                    case "2":
                        CheckUser2 = true;
                        if (!CheckUser1)
                        {
                            Console.WriteLine("Your Inpot is incorrect");
                        }
                        break;
                }
            }
            bool CheckUser3 = false;
            while (!CheckUser3)
            {
                Console.WriteLine("Okay sir, would you like a drink with your meal?");
                Console.WriteLine("1 : yes ");
                Console.WriteLine("2 : No");
                string juicesChoose = Console.ReadLine();
                switch (juicesChoose)
                {
                    case "1":
                        CheckUser3 = true;
                        juices();
                        break;
                    case "2":
                        CheckUser3 = true;
                        Console.WriteLine("Ok Sir have a good day");
                        break;
                        break;

                }

                if (!CheckUser1)
                {
                    Console.WriteLine("Your Inpot is incorrect");
                }
            }


        }

        public void ThirdFoodmenu()
        {
            bool CheckUser = false;
            while (!CheckUser)
            {
                Console.WriteLine($"Our {ThirdFoodMenu} are divided into Four categories");

                Console.WriteLine("We have");
                Console.WriteLine($"1 : {TFM1}");
                Console.WriteLine($"2 : {TFM2}");
                Console.WriteLine($"3 : {TFM3}");
                Console.WriteLine($"4 : {TFM4}");
                string FoodShoose = Console.ReadLine();

                switch (FoodShoose)
                {
                    case "1":
                        CheckUser = true;
                        Console.WriteLine($"We will bring you your meal : {TFM1} as soon as possible");
                        break;
                    case "2":
                        CheckUser = true;
                        Console.WriteLine($"We will bring you your meal : {TFM2} as soon as possible");
                        break;
                    case "3":
                        CheckUser = true;
                        Console.WriteLine($"We will bring you your meal : {TFM3} as soon as possible");
                        break;
                    case "4":
                        CheckUser = true;
                        Console.WriteLine($"We will bring you your meal : {TFM4} as soon as possible");
                        break;
                }
                if (!CheckUser)
                {
                    Console.WriteLine("Your Inpot is incorrect");
                }
            }

            bool CheckUser1 = false;
            while (!CheckUser1)
            {
                Console.WriteLine("Do you want desert with your order");

                Console.WriteLine("1 : yes ");
                Console.WriteLine("2 : No");

                string DesertChoose = Console.ReadLine();

                switch (DesertChoose)
                {
                    case "1":
                        CheckUser1 = true;
                        desert();
                        break;
                    case "2":
                        CheckUser1 = true;
                        bool CheckUser2 = false;
                        while (!CheckUser2)
                        {
                            Console.WriteLine("Okay sir, would you like a drink with your meal?");
                            Console.WriteLine("1 : yes ");
                            Console.WriteLine("2 : No");
                            string juicesChoose = Console.ReadLine();
                            switch (juicesChoose)
                            {
                                case "1":
                                    CheckUser2 = true;
                                    juices();
                                    break;
                                case "2":
                                    CheckUser2 = true;
                                    Console.WriteLine("Ok Sir have a good day");
                                    break;

                            }
                            if (!CheckUser2)
                            {
                                Console.WriteLine("Your Inpot is incorrect");
                            }
                        }
                        break;
                }
                break;
                if (!CheckUser1)
                {
                    Console.WriteLine("Your Inpot is incorrect");
                }
            }





        }


        public void desert()
        {

            bool CheckUser = false;
            while (!CheckUser)
            {
                Console.WriteLine("In the desert section we have 5 main dishes");

                Console.WriteLine($"1 : {FirstDesertMenu}");
                Console.WriteLine($"2 : {SecondDesertMenu}");
                Console.WriteLine($"3 : {ThirdDesertMenu}");
                Console.WriteLine($"4 : {FourthDesertMenu}");
                Console.WriteLine($"5 : {FifthDesertMenu}");
                Console.WriteLine("");
                string DesertChoose = Console.ReadLine();

                switch (DesertChoose)
                {
                    case "1":
                        CheckUser = true;
                        Console.WriteLine($"Our {FirstDesertMenu} are divided into three categories");

                        Console.WriteLine("We have");
                        Console.WriteLine($"1 : {FirstDM1}");
                        Console.WriteLine($"2 : {FirstDM2}");
                        Console.WriteLine($"3 : {FirstDM3}");
                        bool CheckUser8 = false;
                        while (!CheckUser8)
                        {
                            string DesertChoose1 = Console.ReadLine();

                            switch (DesertChoose1)
                            {
                                case "1":
                                    CheckUser8 = true;
                                    Console.WriteLine($"We will bring you your desert : {FirstDM1} as soon as possible");
                                    break;
                                case "2":
                                    CheckUser8 = true;
                                    Console.WriteLine($"We will bring you your desert : {FirstDM2} as soon as possible");
                                    break;
                                case "3":
                                    CheckUser8 = true;
                                    Console.WriteLine($"We will bring you your desert : {FirstDM3} as soon as possible");
                                    break;
                            }
                            if (!CheckUser8)
                            {
                                Console.WriteLine("Your Inpot is incorrect");
                            }
                        }
                        break;

                    case "2":
                        CheckUser = true;
                        Console.WriteLine($"Our {SecondDesertMenu} are divided into three categories");

                        Console.WriteLine("We have");
                        Console.WriteLine($"1 : {SecondDM1}");
                        Console.WriteLine($"2 : {SecondDM2}");
                        Console.WriteLine($"3 : {SecondDM3}");
                        bool CheckUser7 = false;
                        while (!CheckUser7)
                        {
                            string DesertChoose2 = Console.ReadLine();

                            switch (DesertChoose2)
                            {
                                case "1":
                                    CheckUser7 = true;
                                    Console.WriteLine($"We will bring you your desert : {SecondDM1} as soon as possible");
                                    break;
                                case "2":
                                    CheckUser7 = true;
                                    Console.WriteLine($"We will bring you your desert : {SecondDM2} as soon as possible");
                                    break;
                                case "3":
                                    CheckUser7 = true;
                                    Console.WriteLine($"We will bring you your desert : {SecondDM3} as soon as possible");
                                    break;
                            }
                            if (!CheckUser7)
                            {
                                Console.WriteLine("Your Inpot is incorrect");
                            }
                        }

                        break;
                    case "3":
                        CheckUser = true;
                        Console.WriteLine($"Our {ThirdDesertMenu} are divided into three categories");

                        Console.WriteLine("We have");
                        Console.WriteLine($"1 : {ThirdDM1}");
                        Console.WriteLine($"2 : {ThirdDM2}");
                        Console.WriteLine($"3 : {ThirdDM3}");
                        bool CheckUser3 = false;
                        while (!CheckUser3)
                        {
                            string DesertChoose3 = Console.ReadLine();

                            switch (DesertChoose3)
                            {
                                case "1":
                                    CheckUser3 = true;
                                    Console.WriteLine($"We will bring you your desert : {ThirdDM1} as soon as possible");
                                    break;
                                case "2":
                                    CheckUser3 = true;
                                    Console.WriteLine($"We will bring you your desert : {ThirdDM2} as soon as possible");
                                    break;
                                case "3":
                                    CheckUser3 = true;
                                    Console.WriteLine($"We will bring you your desert : {ThirdDM3} as soon as possible");
                                    break;
                            }

                            if (!CheckUser3)
                            {
                                Console.WriteLine("Your Inpot is incorrect");
                            }
                        }
                        break;
                    case "4":
                        CheckUser = true;
                        Console.WriteLine($"Our {FourthDesertMenu} are divided into three categories");

                        Console.WriteLine("We have");
                        Console.WriteLine($"1 : {FourthDM1}");
                        Console.WriteLine($"2 : {FourthDM2}");
                        Console.WriteLine($"3 : {FourthDM3}");
                        bool CheckUser2 = false;
                        while (!CheckUser2)
                        {
                            string DesertChoose4 = Console.ReadLine();

                            switch (DesertChoose4)
                            {

                                case "1":
                                    CheckUser2 = true;
                                    Console.WriteLine($"We will bring you your desert : {FourthDM1} as soon as possible");
                                    break;
                                case "2":
                                    CheckUser2 = true;
                                    Console.WriteLine($"We will bring you your desert : {FourthDM2} as soon as possible");
                                    break;
                                case "3":
                                    CheckUser2 = true;
                                    Console.WriteLine($"We will bring you your desert : {FourthDM3} as soon as possible");
                                    break;
                            }

                            if (!CheckUser2)
                            {
                                Console.WriteLine("Your Inpot is incorrect");
                            }
                        }
                        break;
                    case "5":
                        CheckUser = true;
                        Console.WriteLine($"Our {FifthDesertMenu} are divided into three categories");

                        Console.WriteLine("We have");
                        Console.WriteLine($"1 : {FifthDM1}");
                        Console.WriteLine($"2 : {FifthDM2}");
                        Console.WriteLine($"3 : {FifthDM3}");
                        break;
                }
                bool CheckUser6 = false;
                while (!CheckUser6)
                {
                    string DesertChoose5 = Console.ReadLine();

                    switch (DesertChoose5)
                    {
                        case "1":
                            CheckUser6 = true;
                            Console.WriteLine($"We will bring you your desert : {FifthDM1} as soon as possible");
                            break;
                        case "2":
                            CheckUser6 = true;
                            Console.WriteLine($"We will bring you your desert : {FifthDM2} as soon as possible");
                            break;
                        case "3":
                            CheckUser6 = true;
                            Console.WriteLine($"We will bring you your desert : {FifthDM3} as soon as possible");
                            break;
                    }

                    break;
                }
                bool CheckUser4 = false;
                while (!CheckUser4)
                {
                    Console.WriteLine($"Okay sir, would you like a {Juices} with your desert?");
                    Console.WriteLine("1 : yes ");
                    Console.WriteLine("2 : No");
                    string juicesChoose = Console.ReadLine();
                    switch (juicesChoose)
                    {
                        case "1":
                            CheckUser4 = true;
                            juices();
                            break;
                        case "2":
                            CheckUser4 = true;
                            Console.WriteLine("Ok Sir have a good day");
                            break;
                    }
                    if (!CheckUser4)
                    {
                        Console.WriteLine("Your Inpot is incorrect");
                    }
                }

            }
        }

        public void juices()
        {
            bool CheckUser = false;
            while (!CheckUser)
            {
                Console.WriteLine($"In the {Juices} section we have nine juices");

                Console.WriteLine($"1 : {J1}");
                Console.WriteLine($"2 : {J2}");
                Console.WriteLine($"3 : {J3}");
                Console.WriteLine($"4 : {J4}");
                Console.WriteLine($"5 : {J5}");
                Console.WriteLine($"6 : {J6}");
                Console.WriteLine($"7 : {J7}");
                Console.WriteLine($"8 : {J8}");
                Console.WriteLine($"9 : {J9}");

                Console.WriteLine("What would you like to order");
                string JuicesChoose = Console.ReadLine();
                string JuicesChoose1 = "";
                switch (JuicesChoose)
                {
                    case "1":
                        CheckUser = true;
                        JuicesChoose1 = J1;
                        break;
                    case "2":
                        CheckUser = true;
                        JuicesChoose1 = J2;
                        break;
                    case "3":
                        CheckUser = true;
                        JuicesChoose1 = J3;
                        break;
                    case "4":
                        CheckUser = true;
                        JuicesChoose1 = J4;
                        break;
                    case "5":
                        CheckUser = true;
                        JuicesChoose1 = J5;
                        break;
                    case "6":
                        CheckUser = true;
                        JuicesChoose1 = J6;
                        break;
                    case "7":
                        CheckUser = true;
                        JuicesChoose1 = J7;
                        break;
                    case "8":
                        CheckUser = true;
                        JuicesChoose1 = J8;
                        break;
                    case "9":
                        CheckUser = true;
                        JuicesChoose1 = J9;
                        break;
                }
                if (!CheckUser)
                {
                    Console.WriteLine("Your Inpot is incorrect");
                }
                bool CheckUser1 = false;
                while (!CheckUser1)
                {
                    Console.WriteLine($"Would you like an extra ice with your {JuicesChoose1} juices ");

                    Console.WriteLine("1 : yes ");
                    Console.WriteLine("2 : No");

                    string extraIceChoose = Console.ReadLine();

                    switch (extraIceChoose)
                    {
                        case "1":
                            CheckUser1 = true;
                            Console.WriteLine($"We will bring you your juices : {JuicesChoose1} with an extra ice as soon as possible");
                            break;
                        case "2":
                            CheckUser1 = true;
                            Console.WriteLine($"We will bring you your juices : {JuicesChoose1} as soon as possible");
                            Console.WriteLine("Have a good day sir");
                            break;
                    }

                    if (!CheckUser1)
                    {
                        Console.WriteLine("Your Inpot is incorrect");
                    }
                }
            }

        }
    }
}

