
using T2204M_C.ss1;
public class Program

{
public static void Main(string[] args)
    {
        int x = 10;
        double y = 3.14;
        Console.WriteLine("hello world :" + x);
        string s = "hihihihi";
        int[] ns = new int[3];
        ns[0] = 5;
        ns[1] = 10;
        ns[2] = 15;
        foreach(int n in ns)
        {
            //n
        }

        for(int i = 0; i < ns.Length; i++)
        {
            //ns[i]
        }

        string input = Console.ReadLine();
        int num = Convert.ToInt32(input);
        Console.WriteLine("num = " + num);
        Human h = new Human();
        h.name = "nguyen van an";
       
        h.Run();

    }
}