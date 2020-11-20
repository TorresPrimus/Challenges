using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Week1ThursdayChallenges
{
    [TestClass]
    public class Week1Challenges
    {
        [TestMethod]
        public void MyTestMethod1()
        {
            string name = ("Supercalifragilisticexpalidocious");

            foreach (char letter in name)
            {
                Console.WriteLine(letter);
            }

        }
        [TestMethod]
        public void MyTestMethod2()
        {

            string name = ("Supercalifragilisticexpalidocious");


            foreach (char letter in name)
            {
                if (letter == 'i')
                {
                    Console.WriteLine("i");
                }
                else
                {
                    Console.WriteLine("Not an i");
                }

            }
        }
        [TestMethod]
        public void MyTestMethod3()
        {

            string name = ("Supercalifragilisticexpalidocious");

            int letterCount = 0;

            for (int i = 0; i < name.Length; i++)
            {
                letterCount++;
            }

            Console.WriteLine(letterCount);
        }
        [TestMethod]
        public void MyTestMethod4()
        {
            string name = ("SupercaLifragiListicexpaLidocious");
            string nameChange = name.ToLower();

            foreach (char letter in nameChange)
            {
                if (letter == 'i')
                {
                    Console.WriteLine("i");
                }

                else if (letter == 'l')
                {
                    Console.WriteLine('L');
                }

                else
                {
                    Console.WriteLine("Not an i");
                }

            }
        }
        [TestMethod]
        public void MyTestMethod5()
        {
            string firstName = "Richard";

            string lastName = "Torres";

            int age = 39;

            Console.WriteLine(firstName + " " + lastName + " is " + age + " years old.");
        }
        [TestMethod]
        public void MyTestMethod6()
        {
            string a = "Scott Pilgrim vs. The World";
            string b = "The Matrix";
            string c = "Ready Player One";
            string d = "Star Wars Prequels";

            string[] favMovies = { a, b, c, d };

            string[] favBooks = { "Ready Player One", "Enders Game series", "Drizzt series", "Calvin & Hobbes" };

            foreach (string s in favBooks)
            {
                Console.WriteLine(s);
            }

            foreach (string s2 in favMovies)
            {
                Console.WriteLine(s2);
            }

            Console.WriteLine(favBooks[0]);
        }
        [TestMethod]
        public void MyTestMethod7()
        {
            List<DateTime> listOfDateTime = new List<DateTime>();

            DateTime myBirthDay = new DateTime(1981, 06, 04);
            DateTime herBirthDay = new DateTime(1991, 02, 21);
            DateTime daughtBirthDay = new DateTime(1999, 04, 07);
            DateTime now = DateTime.Now;


            listOfDateTime.Add(myBirthDay);
            listOfDateTime.Add(herBirthDay);
            listOfDateTime.Add(daughtBirthDay);
            listOfDateTime.Add(now);
            listOfDateTime.Add(new DateTime(2020,12,25));

            foreach (DateTime i in listOfDateTime)
            {
                Console.WriteLine(i);
            }
            
        }
        [TestMethod]
        public void MyTestMethod8()
        {
            int age = 39;
            int seven = 7;

            int sum = age + seven;
            Console.WriteLine(sum);
            int diff = age - seven;
            Console.WriteLine(diff);
            int prod = age * seven;
            Console.WriteLine(prod);
            int quot = age / seven;
            Console.WriteLine(quot);
            int remainder = age % seven;
            Console.WriteLine(remainder);
        }
        [TestMethod]
        public void MyTestMethod9()
        {
            int sleepHours = 7;

            if(sleepHours > 10)
            {
                Console.WriteLine("Wow thats a lot of sleep!");
            }

            else if(sleepHours > 8 && sleepHours < 10)
            {
                Console.WriteLine("You got plenty of sleep!");
            }

            else if(sleepHours > 4 && sleepHours < 8)
            {
                Console.WriteLine("Bummer!");
            }
            
            else
            {
                Console.WriteLine("Oh man, Get some sleep!");
            }
        }
        [TestMethod]
        public void MyTestMethod10()
        {
            string howFeel = "good";

            switch (howFeel)
            {
                case "great":
                    Console.WriteLine("I am so happy for you!");
                    break;

                case "good":
                    Console.WriteLine("That's not bad!");
                    break;

                case "okay":
                    Console.WriteLine("What's going on?");
                    break;

                case "bad":
                    Console.WriteLine("Okay let us go grab a drink!");
                    break;

                default:
                    Console.WriteLine("Don't ignore me bud!");
                    break;
            }
        }
    }
}
