using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO2ST2021EX1
{
    public class KanyeInMemoryDb
    {
        public static List<KanyeResponse> kanyeQuotes = new List<KanyeResponse>();
        public List<KanyeResponse> GetAll()
        {
            return kanyeQuotes;
        }
        public KanyeResponse Get(int index)
        {
            return kanyeQuotes[index];
        }
        public void Add(KanyeResponse kanyeResponse)
        {
            kanyeQuotes.Add(kanyeResponse);
        }
        public void Clear()
        {
            kanyeQuotes.Clear();
        }
    }
}
