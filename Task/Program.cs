namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //Console.Write("N=");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int c = 0;
            //for (int i = 1; i <= n; i++)
            //{
            //    if (n % i == 0)
            //    {
            //        c++;
            //    }
            //    if (c > 2 || n == 1)
            //    {
            //        break;
            //    }
            //}

            //if (c > 2)
            //{
            //    Console.WriteLine($"{n} murekkebdir");
            //}
            //else if (n == 1)
            //{
            //    Console.WriteLine("1 Ne sadedir ne de ki murekkebdir");
            //}
            //else if (c <= 2)
            //{
            //    Console.WriteLine($"{n} sadedir");
            //}
            #endregion

            #region Task2
            Console.Write("N=");
            int number=Convert.ToInt32(Console.ReadLine());
            int counter=0;
            int copy=number;
            do
            {
                copy /= 10;
                counter++;
            } while (copy > 0);

            Console.WriteLine($"{number} ededi {counter} mertebelidir.");
            #endregion
        }
    }
}
