using SahaBT_Trainnig.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SahaBT_Trainnig.Models
{
    public class Response : IResponse
    {
        private List<Persons> items = FileRead.GetPersons();
        private List<Persons> male;
        private List<Persons> female;
        private Dictionary<string, List<Persons>> mbc;
        private Dictionary<string, List<Persons>> fbc;

        public List<Persons> Answer1()
        {   // Aynı verileri tespit edilmesi
            var query = (from item in items
                         group item by item.Id into it
                         where it.Count() > 1
                         select new { id = it.Key, count = it.Count() }).ToList();

            foreach (var i in query)
            {   //Tespit edilen verilerin silmesi
                items.RemoveRange(items.FindIndex(0, x => x.Id == i.id), i.count - 1);
            }

            return items;
        }

        public List<Persons> Answer2(int gnd)
        {
            male = items.Where(x => x.Gender == "Male").ToList();
            female = items.Where(x => x.Gender == "Female").ToList();
            if (gnd == 0) return male;
            else if (gnd == 1) return female;
            else return null;
        }

        public Dictionary<string, List<Persons>> Answer3(int cntry) 
        {
            List<Persons> ml = Answer2(0);
            List<Persons> fm = Answer2(1);
            //Ülkelere gruplanıp bu verileri "key" olarak kullanıp ve her bir keyin liste barındırma işlemi 
            if (cntry == 0)
            {
                var countryM = (from item in ml
                                group item by item.Country into cnt
                                select cnt.Key).ToList();

                mbc = new Dictionary<string, List<Persons>>();
                foreach (var item in countryM)
                {
                    mbc.Add(item, ml.Where(q => q.Country == item.ToString()).ToList());
                }
                return mbc;
            }
            else if (cntry == 1) 
            {
                var countryF = (from item in fm
                                group item by item.Country into cnt
                                select cnt.Key).ToList();

                fbc = new Dictionary<string, List<Persons>>();
                foreach (var item in countryF)
                {
                    fbc.Add(item, fm.Where(q => q.Country == item.ToString()).ToList());
                }
                return fbc;
            }       
            else return null;
        }

    }
}
