using MonsterApp.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonsterApp.DataClient
{
    public class GenderMapper
    {
        public static Models.GenderDAO MapToGenderDAO(Gender gender)
        {
            var g = new Models.GenderDAO();

            g.Id = gender.GenderId;
            g.Name = gender.Name;

            return g;
        }

        public Gender MapToGender(Models.GenderDAO gender)
        {
            throw new NotImplementedException();
        }
    }
}