using MonsterWeb.Logic.MonsterServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterWeb.Logic
{
    public class DataService
    {
        private Service1Client msc = new Service1Client();

        
        public List<GenderDAO> GetGenders()
        {
            return msc.GetGenders().ToList();
        }
        

    }
}
