namespace ForTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            int b = 4;
            int c = 8;
            int d = 7;
            int i = 1;
            while(i < 5)
            {
                a--;
                b += a;
                c =  b + a;
                d = (c + a) - i;
                i++;

            }
            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}
