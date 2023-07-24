static void Start(int time){

    int currentTime = 0;

    for(var i = currentTime; i != time; i++ ){

        Console.Clear();
        Console.WriteLine(i);
        Thread.Sleep(500);
    }

    Console.Clear();
    Console.WriteLine("Stopwatch finalizado!");
    Thread.Sleep(1000);
    Menu();
}

static void Menu(){

    Console.Clear();
    Console.WriteLine(" S = Segundo | 10s = 10 segundos");
    Console.WriteLine(" M = Minuto | 1m = 1 minuto");
    Console.WriteLine(" 00 = Sair");
    Console.WriteLine(" Quanto tempo deseja contar? ");

    string data = Console.ReadLine().ToLower();
    char type = char.Parse(data.Substring(data.Length -1, 1));
    int time = int.Parse(data.Substring(0, data.Length -1));
    
    int multiplier = 1;

    if(type == 'm')
        multiplier = 60;

    if(time == 0)
        System.Environment.Exit(0);

    PreStart(time * multiplier);

}
Menu();

static void PreStart(int time){
    Console.Clear();
    Console.WriteLine("Ready...");
    Thread.Sleep(1000);
    Console.WriteLine("Set...");
    Thread.Sleep(1000);
    Console.WriteLine("Go...");
    Thread.Sleep(2000);

    Start(time);
}