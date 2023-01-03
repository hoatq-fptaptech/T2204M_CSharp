using T2204M.session1;
public class Program
{
    public static void Main(string[] args)
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