namespace MonitorWebApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var result = MonitorYourApp.CheckSite("www.github.com/");
            Console.WriteLine(result.responseTime);
            Console.WriteLine(result.status);
        }
    }
}