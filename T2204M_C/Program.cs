
using T2204M_C.ss1;
using T2204M_C.ss2;
using T2204M_C.ss4;
using T2204M_C.exp.tiendien;
public class Program

{


    public static void Main(string[] args)
    {
        NN nN = new NN(1,"hien nguyen","22/02/2022","sinh hoat",150,"nga");
       

        Console.WriteLine(nN.TT());
        VN vN = new VN(2, "hien", "sinh hoat", "22/02/2022",200);
        Console.WriteLine(vN.TT());

    }


    //public static void Main(string[] args)
    //{
    //    Car c = new Car() { Brand = "BMW" ,Type = "Sedan"};
    //    Console.WriteLine(c.machines[0]);
    //    Console.WriteLine(c[1]);
    //    c.machines.Add("led");
    //    try
    //    {
    //        int x = 10;
    //        int y = 0;
    //        if(y == 0)
    //        {
    //            throw new Exception("Error....!");
    //        }
    //        Console.WriteLine("x/y= ");
    //        int z = x / y;

    //        Console.WriteLine(z);
    //    }
    //    catch(Exception e)
    //    {
    //        Console.WriteLine(e.Message);
    //    }


    //}



    //public static void Main(string[] args)
    //{
    //    Dog d = new Dog("a", 2);
    //    d.Color = "red";
    //    Console.Write(d.Color);

    //    Dog[] dd = new Dog[10];
    //    for(int i = 0; i < dd.Length; i++)
    //    {
    //        dd[i] = new Dog();

    //    }

    //    foreach(Dog dog in dd)
    //    {

    //    }

    //    List<Dog> ls = new List<Dog>();

    //    ls.Add(new Dog());
    //    Console.WriteLine(ls.Count);


    //}

    //public static void Main2(string[] args)
    //{
    //    int x = 10;
    //    double y = 3.14;
    //    Console.WriteLine("hello world :" + x);
    //    string s = "hihihihi";
    //    int[] ns = new int[3];
    //    ns[0] = 5;
    //    ns[1] = 10;
    //    ns[2] = 15;
    //    foreach (int n in ns)
    //    {
    //        //n
    //    }

    //    for (int i = 0; i < ns.Length; i++)
    //    {
    //        //ns[i]
    //    }

    //    string input = Console.ReadLine();
    //    int num = Convert.ToInt32(input);
    //    Console.WriteLine("num = " + num);
    //    Human h = new Human();
    //    h.name = "nguyen van an";

    //    h.Run();

    //}
}