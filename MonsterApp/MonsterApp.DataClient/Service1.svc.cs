
using MonsterApp.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MonsterApp.DataClient
{
    public class Service1 : IService1
    {
        private DataAccess.AdoData data = new DataAccess.AdoData();

        List<Models.GenderDAO> IService1.GetGenders()
        {
            var g = new List<Models.GenderDAO>();

            foreach(var gender in data.GetGenders())
            {
                g.Add(GenderMapper.MapToGenderDAO(gender));
            }

            return g;
        }

        List<MonsterTypeDAO> IService1.GetMonsterTypes()
        {
            throw new NotImplementedException();
        }

        List<TitleDAO> IService1.GetTitles()
        {
            throw new NotImplementedException();
        }
    }
}
