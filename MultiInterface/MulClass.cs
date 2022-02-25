using System;

namespace MultiInterface
{
    
    class MulClass:Interface1,Interface2
    {
       public void Test()
       {
            Console.WriteLine("This are pravite property");
       }

        void Interface1.Show()
        {
            Console.WriteLine("1 Show Raju");
        }

        void Interface1.Test()
        {
            Console.WriteLine("1 Test Raju");
        }


        void Interface2.Show()
        {
            Console.WriteLine("2 show Lucky");
        }

       
        void Interface2.Test()
        {
            Console.WriteLine("2 Test Lucky");
        }
        static void Main()
        {
            MulClass m = new MulClass();
            m.Test();
            Interface1 o = m;
            o.Test();
            o.Show();
            Interface2 p = m;
            p.Show();
            p.Test();
            Console.ReadLine();
        }
    }
     
    
}
