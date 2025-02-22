namespace Pdp_Lesson5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter lenght: ");
            //int lengh = int.Parse(Console.ReadLine());
            //var digits = AddMassiv(lengh);
            //Logic(digits);
            //FillGap(digits);

            ///////////////////////////////////////
            var GetClass = new Task2();

            //Console.Write("Engter Lengh");
            //int lengh = int.Parse(Console.ReadLine());
            //var numbers = GetClass.AddMassiv(lengh);
            //GetClass.OddOrEven(numbers);

            //////////////////////////////////////////

            //int[][] array = new int[4][]
            //{
            //    [21,21,21,12,23],
            //    [3,71,32,4,42],
            //    [9,21,91,12,32],
            //    [61,21,21,31,52],

            //};
            //int Odd = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    for (int j = 0; j < array[i].Length; j++)
            //    {
            //        if (array[i][j] % 2 == 1)
            //        {
            //            Odd++;
            //        }
            //    }
            //}

            //Console.WriteLine(Odd);

            

        }


        public static List<int> AddMassiv(int lengh)
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < lengh; i++)
            {
                Console.Write($"{i}: ");
                int elements = int.Parse(Console.ReadLine());
                numbers.Add(elements);
            }

            return numbers;
        }

        public static void Logic(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    numbers[i] *= 2;
                }
            }
        }

        public static void FillGap(List<int> numbers)
        {
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }



    }
}
