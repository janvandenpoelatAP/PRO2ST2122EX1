using System;

namespace PRO2ST2021EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            KanyeService kanyeService  = new KanyeService();
            kanyeService.KanyeQuotesVullen();
            Console.WriteLine(kanyeService.KanyeQuoteRandom());
        }
    }
}
