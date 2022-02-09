using Newtonsoft.Json;
using SahaBT_Trainnig.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SahaBT_Trainnig.Data
{
    public static class FileRead
    {
        private static List<Persons> persons;
        
        /*Veri koleksiyonundan verileri okuyup uygun veri tipinde listede tutma*/
        public static void StartFileRead()
        {
            try
            {
                
                StreamReader r = new StreamReader("./Data/data.json");
                string json = r.ReadToEnd();
                List<Persons> items = JsonConvert.DeserializeObject<List<Persons>>(json);
                persons = items;                
            }
            catch (Exception e) 
            {
                throw;
            }
            
            
        }

        public static List<Persons> GetPersons()
        {
            return persons;
        }

      
    }
}
