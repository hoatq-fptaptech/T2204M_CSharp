using T2204M.session1;
using T2204M.session2;
using System.Collections.Generic;
using T2204M.session3;
using T2204M.session4;
public class Program
{
    public static void Main(string[] args)
    {
        //DemoDelegate.Alert("Cam thanh vien duoi 18 tuoi");
        //DemoDelegate d = new DemoDelegate();
        //d.ShowMessage("Canh bao lan thu nhat");
        PrintString ps = new PrintString(ShowDanger);
        //ps("Nguy hiem lam");
        //ShowDanger("Nguy hiem lam");
        //PrintString ps1 = new PrintString(DemoDelegate.Alert);
        // PrintString ps2 = new PrintString(new DemoDelegate().ShowMessage);

        ps += DemoDelegate.Alert;
        ps += new DemoDelegate().ShowMessage;

        ps("Nguy hiem lam");

        ps += (s) =>
        {
            Console.WriteLine("Anonymus: " + s);
        };

        ps += delegate (string s) {
            Console.WriteLine("Anonymus2: " + s);
        };

        PrintString ps3 = delegate (string s){

	    };

        Button de = new Button(ps3);
        de.ClickAction();
    }

    public static void ShowDanger(string mg)
    {
        Console.WriteLine("Danger: " + mg);
    }

    public static void Main4(string[] args)
    {
        Car c = new Car() { Brand = "Toyota",Type="Sedan"};
        Console.WriteLine(c.machines[0]);
        Console.WriteLine(c[1]);
        //Console.WriteLine(c[2]);
        // c[2] = "Led";
        c.machines.Add("Led");
        try
        {
            int x = 10;
            int y = 0;
            if (y == 0)
            {
                throw new Exception("Error...");
            }
            Console.WriteLine("x/y = ");
            int z = x / y;
            Console.WriteLine(z);
        }catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public static void Main2(string[] args)
    {
        //Dog d = new Dog();
        //d.SetKind("DOG");
        //d.Info();
        Dog d = new Dog("Dog", 12);
        d.Weight = 10;
        d.Color = "yellow";
        Console.WriteLine(d.Weight);
        Console.WriteLine(d.Color);
        Dog[] dd = new Dog[10];

        for(int i = 0; i < dd.Length; i++)
        {
            dd[i] = new Dog();
        }
       // dd[0].Weight = 20;

        foreach(Dog o in dd)
        {
            o.Color = "green";
        }

        List<Dog> ls = new List<Dog>();
        ls.Add(new Dog());
        Console.WriteLine(ls.Count);// .Count -> kich thuoc tap hop
        List<int> ints = new List<int>();

    }

    public static void Main3(string[] args)
    {
        
        double y = 3.14;
        
        string s = "T2204M";

        int x = 10;
        if (x >= 10)
        {
            Console.WriteLine("A");
        }else if (x > 5)
        {
            Console.WriteLine("B");
        }else if (x > 15)
        {
            Console.WriteLine("C");
        }
        else
        {
            Console.WriteLine("D");
        }

        int[] ns = new int[3];

        ns[0] = 15;
        ns[1] = 20;
        ns[2] = 25;

        foreach(int n in ns)
        {
            //n
        }

        for(int i = 0; i < ns.Length; i++)
        {
            // ns[i]
        }

        string input = Console.ReadLine(); // scan
        int num = Convert.ToInt32(input);
        Console.WriteLine("num = " + num);

        Human h = new Human();
        h.name = "Nguyen Van An";
        h.Run();
    }
}

namespace T2204M.session3
{
    public class Moto
    {

    }

    public class Bike
    {

    }
}