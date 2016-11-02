using MonsterApp.DataAccess;
using MonsterApp.DataClient;
using MonsterApp.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MonsterApp.DatClient
{
    public class Service1 : IService1
    {
        private EfData db = new EfData();

        public List<GenderDAO> GetGenders()
        {
            var g = new List<GenderDAO>();

            foreach (var gender in db.GetGenders())
            {
                g.Add(GenderMapper.MapToGenderDAO(gender));
            }

            return g;
        }

        public List<MonsterTypeDAO> GetMonsterTypes()
        {
            throw new NotImplementedException();
        }

        public List<TitleDAO> GetTitles()
        {
            throw new NotImplementedException();
        }
    }
}
