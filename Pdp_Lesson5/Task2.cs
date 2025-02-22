namespace Pdp_Lesson5
{
    public class Task2
    {
        public List<int> AddMassiv(int massiv)
        {
            var numbers = new List<int>();
            for (int i = 0; i < massiv; i++)
            {
                Console.Write($"{i}:");
                int elements = int.Parse(Console.ReadLine());
                numbers.Add(elements);
            }
            return numbers;
        }
        public void Logic(List<int> massiv)
        {
            int count = 0;
            for (int i = 0; i < massiv.Count; i++)
            {
                if (massiv[i] >= 10 && massiv[i] <= 99)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
        public void OddOrEven(List<int> massiv)
        {
            int odd = 0;
            int even = 0;
            for (int i = 0; i < massiv.Count; i++)
            {
                if (massiv[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }

            if (odd > even)
            {
                Console.WriteLine("Toq son");
            }
            else
            {
                Console.WriteLine("Juft son");
            }
        }
    }
}
