using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {

            //Part 1 prompt the user questions, define variables and while statement.

            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine().ToUpper();
            Console.WriteLine();







            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine().ToUpper();
            Console.WriteLine();







            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine().ToUpper());
            Console.WriteLine();




            Console.WriteLine("What month were you born in?");
            string birthMonth = Console.ReadLine().ToUpper();
            Console.WriteLine();


            Console.WriteLine("What is your favorite ROYGBIV color? If you do not know, enter \"HELP\"");
            string color = Console.ReadLine().ToUpper();
            while (color == "HELP")
            {
                Console.WriteLine("Red, Orange, Yellow, Green, Blue, Indigo, Violet.");
                Console.WriteLine();
                Console.WriteLine("What is your favorite ROYGBIV color?");
                color = Console.ReadLine().ToUpper();
            }




            Console.WriteLine();
            Console.WriteLine("How many siblings do you have?");
            int siblings = int.Parse(Console.ReadLine().ToUpper());
            Console.WriteLine();


            //Final half that gives the condition for age, birth month : first and last name comparison, 
            //number of siblings, and favorite ROYBGIV color.
            //Prediction is given at the end. In the form of first name, last name, retirement (in # of years), 
            //amount of $ in bank, vacation home destination, and mode of transportation.

            Console.WriteLine(firstName + " " + lastName + " ");

            if (age % 2 == 1)
            {
                Console.WriteLine("will retire in 10 years");
            }
            else if (age % 2 == 0)
            {
                Console.WriteLine("will retire in 10 million years");

            }



            int sub = firstName.IndexOf(birthMonth[0]);
            int sub2 = firstName.IndexOf(birthMonth[1]);
            int sub3 = firstName.IndexOf(birthMonth[2]);



            int sub16 = lastName.IndexOf(birthMonth[0]);
            int sub17 = lastName.IndexOf(birthMonth[1]);
            int sub18 = lastName.IndexOf(birthMonth[2]);




            if (sub != -1 && sub16 != -1)
            {
                Console.WriteLine("with $50 in the bank, ");
            }
            else if (sub2 != -1 && sub17 != -1)
            {
                Console.WriteLine("with $50,000 in the bank, ");
            }
            else if (sub3 != -1 && sub18 != -1)
            {
                Console.WriteLine("with $50 million in the bank, ");
            }

            else
            {
                Console.WriteLine("with $0 in the bank, ");
            }



            if (siblings == 0)
            {
                Console.WriteLine("a vacation home in Red Riding Hood Woods");
            }
            else if (siblings == 1)
            {
                Console.WriteLine("a vacation home in the Three Little Pigs' Valley");
            }
            else if (siblings == 2)
            {
                Console.WriteLine("a vacaion home in The Seven Dwarfs Mine");
            }
            else if (siblings == 3)
            {
                Console.WriteLine("a vacation home in Briar Rose's Kingdom");
            }
            else if (siblings > 3)
            {
                Console.WriteLine("a vacation home on Rumpelstiltskin's Mountain");
            }

            while (color == "RED")
            {
                Console.WriteLine("and a Royal Carriage.");
                color = Console.ReadLine().ToUpper();
            }
            while (color == "ORANGE")
            {
                Console.WriteLine("and a Magical Pumpkin that turns into a Royal Carriage.");
                color = Console.ReadLine().ToUpper();
            }
            while (color == "YELLOW")
            {
                Console.WriteLine("and a Magical Broom Stick.");
                color = Console.ReadLine().ToUpper();
            }
            while (color == "GREEN")
            {
                Console.WriteLine("and a Magical Fairy.");
                color = Console.ReadLine().ToUpper();
            }
            while (color == "BLUE")
            {
                Console.WriteLine("and a Magical Carpet");
                color = Console.ReadLine().ToUpper();
            }
            while (color == "INDIGO")
            {
                Console.WriteLine("and the Millennium Falcon.");
                color = Console.ReadLine().ToUpper();
            }
            while (color == "VIOLET")
            {
                Console.WriteLine("and a Horse and Buggy");
                color = Console.ReadLine().ToUpper();
            }




            Console.WriteLine("Do you want to play again? (YES/NO)");
            string playAgain = Console.ReadLine();
            while (playAgain.ToUpper() == "YES")
            {

                //Part 1 prompt the user questions, define variables and while statement.


                Console.WriteLine("What is your first name?");



                string firstname = Console.ReadLine().ToUpper();
                Console.WriteLine("    ");



                Console.WriteLine("What is your last name?");
                string lastname = Console.ReadLine().ToUpper();
                Console.WriteLine("    ");


                Console.WriteLine("How old are you?");
                int age1 = int.Parse(Console.ReadLine().ToUpper());
                Console.WriteLine("    ");

                Console.WriteLine("What month were you born in?");
                string birthmonth = Console.ReadLine().ToUpper();
                Console.WriteLine("    ");


                Console.WriteLine("What is your favorite ROYGBIV color? If you do not know, enter \"HELP\"");
                string color1 = Console.ReadLine().ToUpper();
                while (color1 == "HELP")
                {
                    Console.WriteLine("Red, Orange, Yellow, Green, Blue, Indigo, Violet.");
                    Console.WriteLine("    ");
                    Console.WriteLine("What is your favorite ROYGBIV color?");
                    color1 = Console.ReadLine().ToUpper();
                }




                Console.WriteLine("    ");
                Console.WriteLine("How many siblings do you have?");
                int siblings1 = int.Parse(Console.ReadLine().ToUpper());
                Console.WriteLine("    ");


                //Final half that gives the condition for age, birth month : first and last name comparison, 
                //number of siblings, and favorite ROYBGIV color.
                //Prediction is given at the end. In the form of first name, last name, retirement (in # of years), 
                //amount of $ in bank, vacation home destination, and mode of transportation.

                Console.WriteLine(firstname + " " + lastname + " ");

                if (age1 % 2 == 1)
                {
                    Console.WriteLine("will retire in 10 years");
                }
                else if (age1 % 2 == 0)
                {
                    Console.WriteLine("will retire in 10 million years");

                }



                int sub4 = firstname.IndexOf(birthMonth[0]);
                int sub5 = firstname.IndexOf(birthMonth[1]);
                int sub6 = firstname.IndexOf(birthMonth[2]);



                int sub7 = lastname.IndexOf(birthMonth[0]);
                int sub8 = lastname.IndexOf(birthMonth[1]);
                int sub9 = lastname.IndexOf(birthMonth[2]);




                if (sub4 != -1 && sub7 != -1)
                {
                    Console.WriteLine("with $50 in the bank, ");
                }
                else if (sub5 != -1 && sub8 != -1)
                {
                    Console.WriteLine("with $50,000 in the bank, ");
                }
                else if (sub6 != -1 && sub9 != -1)
                {
                    Console.WriteLine("with $50 million in the bank, ");
                }

                else
                {
                    Console.WriteLine("with $0 in the bank, ");
                }



                if (siblings1 == 0)
                {
                    Console.WriteLine("a vacation home in Red Riding Hood Woods");
                }
                else if (siblings1 == 1)
                {
                    Console.WriteLine("a vacation home in the Three Little Pigs' Valley");
                }
                else if (siblings1 == 2)
                {
                    Console.WriteLine("a vacaion home in The Seven Dwarfs Mine");
                }
                else if (siblings1 == 3)
                {
                    Console.WriteLine("a vacation home in Briar Rose's Kingdom");
                }
                else if (siblings1 > 3)
                {
                    Console.WriteLine("a vacation home on Rumpelstiltskin's Mountain");
                }

                while (color1 == "RED")
                {
                    Console.WriteLine("and a Royal Carriage.");
                    color1 = Console.ReadLine().ToUpper();
                }
                while (color1 == "ORANGE")
                {
                    Console.WriteLine("and a Magical Pumpkin that turns into a Royal Carriage.");
                    color1 = Console.ReadLine().ToUpper();
                }
                while (color1 == "YELLOW")
                {
                    Console.WriteLine("and a Magical Broom Stick.");
                    color1 = Console.ReadLine().ToUpper();
                }
                while (color1 == "GREEN")
                {
                    Console.WriteLine("and a Magical Fairy.");
                    color1 = Console.ReadLine().ToUpper();
                }
                while (color1 == "BLUE")
                {
                    Console.WriteLine("and a Magical Carpet");
                    color1 = Console.ReadLine().ToUpper();
                }
                while (color1 == "INDIGO")
                {
                    Console.WriteLine("and the Millennium Falcon.");
                    color1 = Console.ReadLine().ToUpper();
                }
                while (color1 == "VIOLET")
                {
                    Console.WriteLine("and a Horse and Buggy");
                    color1 = Console.ReadLine().ToUpper();

                }


                Console.WriteLine("Do you want to play again? (YES/NO)");
                playAgain = Console.ReadLine().ToUpper();


            }









        }
    }
}
