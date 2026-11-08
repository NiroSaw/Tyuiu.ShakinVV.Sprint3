namespace ForTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "cdfgcc cfgc ctf";
            foreach(char c in str)
            {
                if (c == 'c')
                {
                    str = str.Replace(c, 'w');
                }

            }
            Console.WriteLine(str);
            Console.ReadKey();
        }

    }
}
