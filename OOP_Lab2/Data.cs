using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab2
{
    internal class Data
    {
        private DateTime biezData;

        public Data()
        {
            biezData = DateTime.Now;
        }

        public DateTime PobiezBiezDate()
        {
            return biezData;
        }


        public void PrzesDoPrzod()
        {
            biezData = DateTime.Now;
            biezData = biezData.AddDays(7);
        }

        public void PrzesDoTyl()
        {
            biezData = DateTime.Now;
            biezData = biezData.AddDays(-7);
        }
    }
}
