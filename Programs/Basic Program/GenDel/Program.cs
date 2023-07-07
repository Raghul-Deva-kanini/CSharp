using GenDel;

//public delegate void MyDelegate(string msg);
public delegate int MyDelegate();

class Program
{
    /*
    static void Swap<T>(ref T n1, ref T n2)
    {
        T temp;
        temp = n1;
        n1 = n2;
        n2 = temp;
    }
    */

    /*
    static void InvokeDelegate(MyDelegate del)
    {
        del("Hello world");
    }
    */
    public static void Main(string[] args)
    {
        /*
        GenUse<int> guint = new GenUse<int>(10);
        GenUse<double> gudbl = new GenUse<double>(456.15154);
        GenUse<string> gustr = new GenUse<string>("MONSTER");

        Console.WriteLine(guint.Number);
        Console.WriteLine(gudbl.Number);
        Console.WriteLine(gustr.Number);
        
        GenUse<ArithmeticException> ae = new GenUse<ArithmeticException>(1);

        GenUse<int> intarr = new GenUse<int>(5);
        for(int i=0;i<5;i++)
        {
            intarr.setarr(i, i * 10);
        }

        //Console.WriteLine(intarr.getarr(1));
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(intarr.getarr(i));
        }

        GenUse<char> chararray = new GenUse<char>(5);
        for (int i = 0; i < 5; i++)
        {
            chararray.setarr(i, Convert.ToChar(i+65));
        }
        //Console.WriteLine(intarr.getarr(1));
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(chararray.getarr(i));
        }
        
        GenUse<ArithmeticException> ae = new GenUse<ArithmeticException>(arithmeticException());
        Console.WriteLine(ae.disp().Message);
        
        int n1 = 10, n2 = 20;

        Swap<int>(ref n1, ref n2);
        Console.WriteLine(n1+ "\n" + n2);
       

        MyDelegate delobj1, delobj2;
        delobj1 = Deluse1.Method1;
        //delobj1("Hello");
        delobj2 = Deluse2.Method1;
        //delobj1("Hi");

        InvokeDelegate(delobj1);

        InvokeDelegate(delobj2);
         */

        MyDelegate del1 = Deluse1.Method1;
        MyDelegate del2 = Deluse2.Method2;

        //MyDelegate del = del1+ del2;
        //Console.WriteLine("After del1 + del2");
        //del("Hello");
        MyDelegate del = del1 + del2;
        Console.WriteLine(del());
        //Console.WriteLine(del2());

    }
}