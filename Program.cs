using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

namespace _11653725_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextLength();

        }

        static void TextLength()
        {
            string input1 = Console.ReadLine();
            int Parameter = input1.Length;
        }

        public int product(int Parameter)
        {
            return Parameter;
        }

    }

  
}


namespace _11653725_functions
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            SquareRoot();

        }

        static void SquareRoot()
        {
            string input2 = Console.ReadLine();
            int number = int.Parse(input2);

            int Parameter2 = number * number;
        }

        public int product(int Parameter2)
        {
            return Parameter2;
        }
    }

}


namespace _11653725_functions
{
    internal class Program3
    {
        static void Main(string[] args)
        {
            PrintHappyBirthday();

        }

        static void PrintHappyBirthday()
        {
            string input3 = Console.ReadLine();
            bool text = bool.Parse(input3);

            if (text = false)
            {
                string Parameter3 = "";

            } else if (text = true)
            {
                string Parameter3 = "Vše nejlepší!";
            }
        }

        public string product(string Parameter3)
        {
            return Parameter3;
        }

    }


}


namespace _11653725_functions
{
    internal class Program4
    {
        static void Main(string[] args)
        {
            IsOdd();

        }

        static void IsOdd()
        {
            string input4 = Console.ReadLine();
            int number = int.Parse(input4);
            
            if (number % 2 == 0 )
            {
                string Paremeter4 = "sude";

            } else if (number % 2 != 0 ) 
            {
                string Parameter4 = "liche";

            }
            
        }

        public string product(string Parameter4)
        {
            return Parameter4;
        }

    }


}


namespace _11653725_functions
{
    internal class Program5
    {
        static void Main(string[] args)
        {
            Counter();

        }

        static void Counter()
        {
            string input5 = Console.ReadLine();
            int number = int.Parse(input5);
            
            while (number > 0)
            {
                static int product(int Parameter5)
                {
                    return Parameter5;
                    Parameter5 -= 1;
                }
            }
            
        }

    }


}