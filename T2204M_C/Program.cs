
using T2204M_C.ss1;
using T2204M_C.ss2;
using T2204M_C.ss4;
using T2204M_C.exp.tiendien;
using T2204M_C.ss5;
using T2204M_C.exp.as8;
using System.Net.Http;
using T2204M_C.ss6;
using Newtonsoft.Json;

public class Program

{
    public static void Main(string[] args)
    {
        Thread thread = new Thread(RunThread);
        thread.Start("Xin chao");
        Thread t2 =new Thread(delegate() {

            Console.WriteLine("Demo anonymous function");
	});

        t2.Start();
        
        Console.WriteLine("Main done");

        
    }


    static void RunThread(Object o)
    {
        for(int i = 0; i < 20; i++)
        {
            Console.WriteLine(o+"i=:" + i);
            try
            {
                Thread.Sleep(1000);
            }
            catch (Exception e)
            {

            }
        }
    }







    static async Task<Root> CallApi()
    {
        String url = "https://api.openweathermap.org/data/2.5/weather?q=Hanoi,vietnam&appid=09a71427c59d38d6a34f89b47d75975c&units=metric";
        HttpClient httpClient = new HttpClient();
        var rs = await httpClient.GetAsync(url);//lay data ve

        if(rs.StatusCode == System.Net.HttpStatusCode.OK)
        {
            string content = await rs.Content.ReadAsStringAsync();
            Root r = JsonConvert.DeserializeObject<Root>(content);
            return r;
        }
        return null;
    }







    //public static void Main(string[] args)
    //{
    //    DemoDelegate.Alert("cam thanh vien duoi 18t");
    //    DemoDelegate d = new DemoDelegate();
    //    d.ShowMessage("canh bao lan 1");

    //    PrintString pgs = new PrintString(ShowDanger);
    //    //pgs("nguy hiem lam");


    //    //PrintString ps2 = new PrintString(DemoDelegate.Alert);
    //    //PrintString ps3 = new PrintString(new DemoDelegate().ShowMessage);



    //    pgs += DemoDelegate.Alert;
    //    pgs += new DemoDelegate().ShowMessage;
    //    pgs("nguy hiem lam");

    //    pgs += (s) =>
    //    {
    //        Console.WriteLine("Anonymus :" + s);
    //    };











    //    DemoEvent de = new DemoEvent();
    //    de.ClickAction();

    //}



    //public static void ShowDanger(String mg)
    //{
    //    Console.WriteLine("a" + mg);
    //}










    //public static void Main(string[] args)
    //{



    //    NN nN = new NN(1,"hien nguyen","22/02/2022","sinh hoat",150,"nga");
    //    NN nN2 = new NN(1, "hien nguyen", "22/02/2022", "sinh hoat", 250, "nga");



    //    Console.WriteLine(nN.TT());
    //    VN vN = new VN(2, "hien", "sinh hoat", "22/02/2022",200);
    //    Console.WriteLine(vN.TT());

    //}


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