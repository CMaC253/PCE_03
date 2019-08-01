using System;

namespace PCE_StarterProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Simple_Loops sl = new Simple_Loops();
            //sl.RunExercise();

            //Break_Continue_Keywords bck = new Break_Continue_Keywords();
            //bck.RunExercise();

            //Compound_Operators co = new Compound_Operators();
            //co.RunExercise();

            // Increment_Decrement id = new Increment_Decrement();
            // id.RunExercise();

            // Integer_Vs_Real_Division ivrd = new Integer_Vs_Real_Division();
            // ivrd.RunExercise();

            // Modulus_Operator mo = new Modulus_Operator();
            // mo.RunExercise();

            // Fahrenheit_To_Celsius ftc = new Fahrenheit_To_Celsius();
            // ftc.RunExercise();

            RandomNumbersBasic rnb = new RandomNumbersBasic();
            rnb.RunExercise();

            //Sentinel_Controlled_Loop scl = new Sentinel_Controlled_Loop();
            //scl.RunExercise();

            Print_A_Range_Of_Numbers paron = new Print_A_Range_Of_Numbers();
            paron.RunExercise();

            //Nested_Loops_Rectangles nlr = new Nested_Loops_Rectangles();
            //nlr.RunExercise();

            Nested_Loops_Hollow_Rectangles nlhr = new Nested_Loops_Hollow_Rectangles();
            nlhr.RunExercise();

            Built_In_Math_Functions bimf = new Built_In_Math_Functions();
            bimf.RunExercise();
        }
    }


    class Simple_Loops
    {
        public void RunExercise()
        {
            Console.WriteLine("Enter a value for the number of stars in a given line: ");
            int x;
            Int32.TryParse(Console.ReadLine(), out x);
            Console.WriteLine("You entered: {0}! ", x);
            Console.WriteLine("{0} stars you get!", x);
            while ( x > 0 )
            {                
                Console.Write("*");
                x--;
            }
            Console.WriteLine("\nEnter a value for the number of stars in a given line: ");
            int i = 0;
            Int32.TryParse(Console.ReadLine(), out i);

            Console.WriteLine("You entered: {0}! ", i);
            Console.WriteLine("{0} stars you get!", i);
            for (; i > 0; i--)
            {
                Console.Write("*");
            }
            Console.WriteLine("\nLet's see the line, how many stars? ");
            int a;
            Int32.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("You entered: {0}! ", a);
            Console.WriteLine("{0} stars you get!", a);
            do
            {
                Console.Write("*");
                a--;
            }
            while (a > 0);
        }
    }

    class Break_Continue_Keywords
    {
        public void RunExercise()
        {
            Console.WriteLine("_______________________________________________________________________________");
            Console.WriteLine("Try to guess the number, only rules are: ");
            Console.WriteLine("You have 20 guesses, it has to be above the number 10");
            Console.WriteLine("Just know that a number under 10 won't affect you're total number of guesses");
            Console.WriteLine("Please enter a number: ");
            Console.WriteLine("_______________________________________________________________________________");
            for (int a = 20; a > 0; a--)
            {
                Console.WriteLine("You have {0} turns left" + "\nGo:", a);
                int x;
                Int32.TryParse(Console.ReadLine(), out x);
                if (x < 10)
                {
                    Console.WriteLine("Be careful, you're number was less than ten. ");
                    a++;
                    continue;
                }
                else if (x == 201)
                {
                    Console.WriteLine("You did it! 201 is the secret number");
                    Console.WriteLine("Thank you for your time.");
                    break;
                }
                else
                    continue;    

            }
        }
    }

    class Compound_Operators
    {
        public void RunExercise()
        {
            int num = 0;
            // ++ before num is 'prefix' 
            while (++num < 10)
                Console.WriteLine("Num: {0}", num);

            num = 0;
            // ++ after num is 'postfix' 
            while (num++ < 10)
                Console.WriteLine("Num: {0}", num);

            num = 10;
            // -- before num is 'prefix' 
            while (--num > 0)
                Console.WriteLine("Num: {0}", num);

            num = 10;
            // -- after num is 'postfix' 
            while (num-- > 0)
                Console.WriteLine("Num: {0}", num);


        }
    }

    class Increment_Decrement
    {
        public void RunExercise()
        {
            int num = 0;
            // ++ before num is 'prefix' 
            while (++num < 10)
                Console.WriteLine("Num: {0}", num);

            num = 0;
            // ++ after num is 'postfix' 
            while (num++ < 10)
                Console.WriteLine("Num: {0}", num);

            num = 10;
            // -- before num is 'prefix' 
            while (--num > 0)
                Console.WriteLine("Num: {0}", num);

            num = 10;
            // -- after num is 'postfix' 
            while (num-- < 10)
                Console.WriteLine("Num: {0}", num);
        }
    }

    class Integer_Vs_Real_Division
    {
        public void RunExercise()
        {
        }
    }

    class Modulus_Operator
    {
        public void RunExercise()
        {
        }
    }

    class Fahrenheit_To_Celsius
    {
        public void RunExercise()
        {
        }
    }

    class RandomNumbersBasic
    {
        Random dieToRoll = new Random();
       public void RunExercise()
        {
            //Random dieToRoll = new Random();

            int num;
            int freq1 = 0, freq2 = 0, freq3 = 0, freq4 = 0, freq5 = 0, freq6 = 0;

            for (int i = 0; i < 1000; i++)
            {

                //Random dieToRoll = new Random();
                //You'll see the same number generated because the random number is getting it's random number from the clock,
                // which locks it into any given number within a millisecond time frame.
                //Therefore, since the computer reads code at a very fast rate, the same number will be generated multiple times at the same rate, then change.
                //dieToRoll.Next();
                num = dieToRoll.Next(1, 7);
                Console.WriteLine("{0}", num);
                
                switch (num)
                {
                    case 1:
                        ++freq1;
                        break;
                    case 2:
                        ++freq2;
                        break;
                    case 3:
                        ++freq3;
                        break;
                    case 4:
                        ++freq4;
                        break;
                    case 5:
                        ++freq5;
                        break;
                    case 6:
                        ++freq6;
                        break;
                }      
            }
            Console.WriteLine("Number\tFrequency Generated:");
            Console.WriteLine("1\t{0}\n2\t{1}\n3\t{2}\n4\t{3}\n5\t{4}\n6\t{5}", freq1,freq2,freq3,freq4,freq5,freq6);
        }
    }

    class Sentinel_Controlled_Loop
    {
        public void RunExercise()
        {
        }
    }

    class Print_A_Range_Of_Numbers
    {
        public void RunExercise()
        {
            Console.WriteLine("Greetings, User!");
            Console.WriteLine("Welcome to NumberPrinter!");
            Console.WriteLine("Do you want to quit (1), or print numbers(2) ?");
            int x;
            Int32.TryParse(Console.ReadLine(), out x);

            while (x == 1)
            {
                Console.WriteLine("Good bye");
                break;
            }
            if (x == 2)
            {
                Console.WriteLine("Do you want to print even(1) or odd(2) numbers ?");
                Int32.TryParse(Console.ReadLine(), out x);
                if (x == 1)
                {
                    int a, b;
                    Console.WriteLine("Lowest number ?");
                    Int32.TryParse(Console.ReadLine(), out a);
                    Console.WriteLine("Highest Number ?");
                    Int32.TryParse(Console.ReadLine(), out b);
                    for (; a <= b; a += 2)
                    {
                        while (a % 2 != 0)
                        {
                            a++;
                        }
                        Console.WriteLine(a);
                    }
                }
                if (x == 2)
                {
                    int a;
                    int b;
                    Console.WriteLine("Lowest number ?");
                    Int32.TryParse(Console.ReadLine(), out a);
                    Console.WriteLine("Highest Number ?");
                    Int32.TryParse(Console.ReadLine(), out b);
                    for (; a <= b; a++)
                    {
                        if (a % 2 != 0)
                            Console.WriteLine(a);
                    }
                }
            }
        }
      }

    class Nested_Loops_Rectangles
    {
        public void RunExercise()
        {
            int x,y;
            
            Console.WriteLine("Welcome to RectanglePrinter!");
            Console.WriteLine("How many columns wide should the rectangle be?");
            Int32.TryParse(Console.ReadLine(), out x);
            Console.WriteLine("How many rows tall should the rectangle be?");
            Int32.TryParse(Console.ReadLine(), out y);
            Console.WriteLine("Here you go:\n");
            for (int iRow = 0; iRow <y; iRow++ )
            {
                if (iRow == 1 || iRow == x)
                {
                    for (int iCol = 0; iCol < x; iCol++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                if (iRow<x && iRow< x-1)
                {
                    Console.WriteLine("*");
                    for(int i=0; i<y-2; i++)
                    {
                        Console.Write(" ");  
                    }
                    Console.Write("*");
                    Console.WriteLine();
                }
            }
      
  }
    }

    class Nested_Loops_Hollow_Rectangles
    {
        public void RunExercise()
        {
            {
                int x, y;
                Console.WriteLine("Welcome to RectanglePrinter!");
                Console.WriteLine("How many columns wide should the rectangle be?");
                Int32.TryParse(Console.ReadLine(), out x);
                Console.WriteLine("How many rows tall should the rectangle be?");
                Int32.TryParse(Console.ReadLine(), out y);
                Console.WriteLine("Here you go:\n");
                for (int iRow = 1; iRow <= x; iRow++)
                {

                    if (iRow == 1 || iRow == x)
                    {
                        for (int iCol = 1; iCol <= y; iCol++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                   else if (iRow < x && iRow < x - 1)
                    {
                        Console.Write("*");
                        for (int i = 0; i < y - 2; i++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("*");
                        Console.WriteLine();
                    }
                }
             }
        }
    
    }

    class Built_In_Math_Functions
    {
        public void RunExercise()
        {
            double x,y;
            Console.WriteLine("Please enter a number (x) and enter a number for the exponent(y): ");
            Double.TryParse(Console.ReadLine(), out x);
            Double.TryParse(Console.ReadLine(), out y);
            double exponent = Math.Pow(x,y);
            Console.WriteLine("The result is: {0}",exponent);
            Console.WriteLine("Please enter a number to take the square root of: ");
            Double.TryParse(Console.ReadLine(), out x);
            double squareRoot = Math.Sqrt(x);
            Console.WriteLine("{0} is the square root of {1}",squareRoot, x);
            Console.WriteLine("Please enter a number to take the Sine: ");
            Double.TryParse(Console.ReadLine(), out x);
            double sinFind = Math.Sin(x);
            Console.WriteLine("{0} is the result of {1}", sinFind, x);
            Console.WriteLine("Please enter a number to take the Cos: ");
            Double.TryParse(Console.ReadLine(), out x);
            double cosFind = Math.Cos(x);
            Console.WriteLine("{0} is the result of {1}", cosFind, x);
        }
    }
}
