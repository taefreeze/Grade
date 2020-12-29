using System;

namespace its
{
    class Program
    {
        static void Main(string[] args)
        {
            Rate();
        }
        static void Rate()
        {
            int Number = 1,score = 0;
            Console.WriteLine("Take a survey plz");
            do
            {
            Console.WriteLine("#" + Number);
            Console.WriteLine("Input score that you like A-E");
            string rate = Console.ReadLine();
                switch (rate)
                {
                case "A" :
                case "a" :
                    score += 5;
                    Number +=1;
                    break;
                case "B":
                case "b":
                    score += 4;
                    Number +=1;
                    break;
                case "C":
                case "c":
                    score += 3;
                    Number +=1;
                    break;
                case "D":
                case "d":
                    score += 2;
                    Number +=1;
                    break;
                case "E":
                case "e":
                    score += 1;
                    Number +=1;
                    break;
                }
            } while (Number != 5);{
                int result = score * 5;
                Console.WriteLine("The survey rate is " + result + "%");
            }
        }
        static void GradeIF()
        {
            int a,b,c,d,e;
            Console.WriteLine("Enter number a : ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number b : ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number c : ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number d : ");
            d = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number e : ");
            e = int.Parse(Console.ReadLine());

            int result = a + b + c + d + e;
            if (result > 100)
                {
                    Console.WriteLine("Error");
                }
                else if (result >= 80)
                {
                    Console.WriteLine("Your grade is A");
                }
                else if (result >= 75)
                {
                    Console.WriteLine("Your grade is B+");
                }
                else if (result >= 70)
                {
                    Console.WriteLine("Your grade is B");
                }
                else if (result >= 65)
                {
                    Console.WriteLine("Your grade is C+");
                }
                else if (result >= 60)
                {
                    Console.WriteLine("Your grade is C");
                }
                else if (result >= 55)
                {
                    Console.WriteLine("Your grade is D+");
                }
                else if (result >= 50)
                {
                    Console.WriteLine("Your grade is D");
                }
                else 
                {
                    Console.WriteLine("Your grade is F");
                }
            }
            static void GradeSwitch()
            {
                int a,b,c,d,e;
            Console.WriteLine("Enter number a : ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number b : ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number c : ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number d : ");
            d = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number e : ");
            e = int.Parse(Console.ReadLine());

            int result = a + b + c + d + e;
                switch (result)
            {
                case > 100:
                    Console.WriteLine("Error");
                    Console.ReadLine();
                    break;
                case >= 80:
                    Console.WriteLine("Your grade is A");
                    Console.ReadLine();
                    break;
                case >= 75:
                    Console.WriteLine("Your grade is B+");
                    Console.ReadLine();
                    break;
                case >= 70:
                    Console.WriteLine("Your grade is B");
                    Console.ReadLine();
                    break;
                case >= 65:
                    Console.WriteLine("Your grade is C+");
                    Console.ReadLine();
                    break;
                case >= 60:
                    Console.WriteLine("Your grade is C");
                    Console.ReadLine();
                    break;
                case >= 55:
                    Console.WriteLine("Your grade is D+");
                    Console.ReadLine();
                    break;
                case >= 50:
                    Console.WriteLine("Your grade is D");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
