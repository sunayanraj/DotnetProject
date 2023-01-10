namespace ConsoleApp1
{
    public class Program
    {
        private void Test1()
        {
            Console.WriteLine("Private Method");
        }

        internal void Test2()
        {
            Console.WriteLine("Internal Method");
        }

        protected void Test3()
        {
            Console.WriteLine("Protected Method");
        }

        protected internal void Test4()
        {
            Console.WriteLine("Protected internal Method");
        }

        public void Test5()
        {
            Console.WriteLine("Public Method");
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Test1(); p.Test2();p.Test3();p.Test4();p.Test5(); //we can access all the access specifiers
                                                                //(public,private,protected,internal and protected internal) if it is in the same class i.e.
                                                                //Program but not if it is called in different class.
            Console.ReadLine();
        }
    }
}
