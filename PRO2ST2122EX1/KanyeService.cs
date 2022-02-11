using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO2ST2021EX1
{
    public class KanyeService
    {

        KanyeInMemoryDb kanyeInMemoryDb = new KanyeInMemoryDb();
        public void KanyeQuotesVullen()
        {
            KanyeApiService kanyeApiService = new KanyeApiService();
            KanyeInMemoryDb kanyeInMemoryDb = new KanyeInMemoryDb();

            kanyeInMemoryDb.Clear();
            for (int i = 0; i < 10; i++)
            {
                kanyeInMemoryDb.Add(kanyeApiService.KanyeQuote());
            }
        }

        public string KanyeQuoteRandom()
        {
            Random random = new Random();
            return (kanyeInMemoryDb.Get(random.Next(kanyeInMemoryDb.GetAll().Count)).quote);
        }
    }
}
