using Proxy_Pattern;

class Program
{
    static void Main(string[] args)
    {
        Proxy proxy = new Proxy(TimeSpan.FromSeconds(10));
        Console.WriteLine(proxy.Request("Запрос 1"));
        Console.WriteLine(proxy.Request("Запрос 1"));
        Thread.Sleep(9000);
        Console.WriteLine(proxy.Request("Запрос 1"));
    }
}