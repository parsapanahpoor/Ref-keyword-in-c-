namespace Ref_keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 20;

            PlusNumber1(a);//Will Print 21
            Console.WriteLine(a);//Will Print 20

            PlusNumber2(ref b);//Will Print 21
            Console.WriteLine(b);//Will Print 21

            Console.ReadKey();
        }

        public static void PlusNumber1(int a)
        {
            a++;
            Console.WriteLine(a);
        }

        public static void PlusNumber2(ref int b)
        { 
            b++;
            Console.WriteLine(b);
        }
    }
}