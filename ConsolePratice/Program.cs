using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolePratice
{
    class Program
    {
        static void Main()
        {
            decimal? CASE_LENGTH = 34.2m;
            decimal? CASE_WIDTH = 32.2m;
            decimal? CASE_HEIGHT = 53.6m;
            int? SET_COUNT = 3;
            string cbm = (CASE_LENGTH  * CASE_WIDTH * CASE_HEIGHT / 1000000).Value.ToString("0.###");
            cbm = "0";
            Console.WriteLine(cbm);
            Console.WriteLine(decimal.Parse(cbm));
            string a = (decimal.Parse(cbm) * SET_COUNT).Value.ToString();

            Console.WriteLine(a);
           
            //EnumExample();
            //BuilderExample();

            //CheckRepeat();
        }

        private static void BuilderExample()
        {
            var builder = new StringBuilder("Hello World");
            builder.Append('-', 10)
                   .AppendLine()
                   .Append("Header")
                   .AppendLine()
                   .Append('-', 10)
                   .Replace('-', '+')
                   .Remove(0, 10)
                   .Insert(0, new string('-', 10));

            Console.WriteLine(builder);
            Console.WriteLine("First Char: " + builder[0]);
        }

        private static void SummarizeExample()
        {
            var sentence = "This is realy really really really really long sentence.";
            var summary = StringUtility.SummarizeText(sentence, 25);
            Console.WriteLine(summary);
        }

        private static void StringExample()
        {
            var fullname = "Ray Wu  ";
            Console.WriteLine("Trim: {0}.", fullname.Trim());

            var index = fullname.IndexOf(' ');
            var firstName = fullname.Substring(0, index);
            var lastName = fullname.Substring(index + 1);
            Console.WriteLine(firstName);
            Console.WriteLine(lastName.Trim() + ".");

            var name = fullname.Split(' ');
            Console.WriteLine("First Name: {0}", name[0]);
            Console.WriteLine("Last Name: {0}", name[1]);


            Console.WriteLine(fullname.Replace("Ray", "Raysdfd"));

            var str = "25";
            var age = Convert.ToByte(str);

            float price = 25.25f;
            Console.WriteLine(price.ToString("C"));
        }

        private static void CheckRepeat()
        {
            var str = new List<string>();
            var number = "3071,3262,3117,3264,3166,3285,3301,3360,3363,3403,3378,3414,3424,3421,3460,3445,2993,3475,2995,3488,3014,3492,3041,3494,3058,3505,3083,3511,3098,3520,3102,3111,3122,3128,3133,3149,3159,3175,3185,3195,3206";

            var numbers = number.Split(',');

            foreach (var n in numbers)
            {
                if (str.Contains(n))
                    Console.WriteLine("Existed: " + n);
                else
                    str.Add(n);
            }
        }

        private static void SpiltExample()
        {
            string[] elements;
            var input = Console.ReadLine();
            elements = input.Split(',');
            foreach (var item in elements)
                Console.WriteLine(item);
        }

        private static void ListNumber()
        {
            int number;
            var numbers = new List<int>();

            Console.WriteLine("Type some number here.");
            do
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(number))
                    numbers.Add(number);
                else
                    Console.WriteLine("This number is exist.");
            } while (numbers.Count < 5);

            numbers.Sort();
            
            foreach (var n in numbers)
                Console.WriteLine(n);
        }

        private static void ListChar()
        {
            Console.WriteLine("Type yuor name, please.");

            var input = Console.ReadLine();
            var names = new char[input.Length];

            for (int i = input.Length; i > 0 ; i--)
                names[input.Length - i] = input[i-1];

            var reversed = new string(names);
            Console.WriteLine(reversed);
        }

        private static void ListExample()
        {
            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1);
            numbers.AddRange(new int[3] { 5, 6, 7 });

            foreach (var number in numbers)
                Console.WriteLine(number);

            Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
            Console.WriteLine("Last index of 1: " + numbers.LastIndexOf(1));

            foreach (var number in numbers)
                Console.WriteLine(number);
        }

        private static void ArrayExample()
        {
            var numbers = new[] { 2, 7, 9, 2, 13, 5 };

            Console.WriteLine("Length: " + numbers.Length);

            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9: " + index);

            Console.WriteLine("Effect of Clear()");
            Array.Clear(numbers, 0, 2);
            foreach (var item in numbers)
                Console.WriteLine(item);

            //Copy
            Console.WriteLine("Effect of Copy()");
            var another = new int[3];
            Array.Copy(numbers, another, 3);
            foreach (var item in another)
                Console.WriteLine(item);

            Console.WriteLine("Effect of Sort()");
            Array.Sort(another);
            foreach (var item in another)
                Console.WriteLine(item);


            Console.WriteLine("Effect of Reverse()");
            Array.Reverse(another);
            foreach (var item in another)
                Console.WriteLine(item);
        }

        private static void WhileExample()
        {
            while (true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }

                break;
            }
        }

        private static void RandomExample()
        {
            var random = new Random();

            const int passwordLength = 10;
            var buffer = new char[passwordLength];
            for (int i = 0; i < buffer.Length; i++)
                buffer[i] = (char)('a' + random.Next(0, 26));
            //倒出來方法一
            foreach (var item in buffer)
                Console.WriteLine(item);

            //方法2：用string class 裝 char[]
            var password = new string(buffer);
            Console.WriteLine(password);
        }

        private static void EnumExample()
        {
            //使用宣告好的Enum
            var number = MagicNumber.Express;
            Console.WriteLine((int)number);
            Console.WriteLine(number.ToString());
            //透過數字找Enum
            var magicId = 3;
            Console.WriteLine((MagicNumber)magicId);
            //透過字串找Enum
            var magicName = "Express";
            var magicMethod = (MagicNumber)Enum.Parse(typeof(MagicNumber), magicName);
            Console.WriteLine((int)magicMethod);
        }
    }
}
