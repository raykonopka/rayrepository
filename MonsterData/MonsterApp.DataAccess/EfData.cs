using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterApp.DataAccess
{
    public class EfData
    {
        private MonsterDBEntities2 db = new MonsterDBEntities2();

        public List<Gender> GetGenders()
        {
            return db.Genders.ToList();
        }


        public bool InsertGender(Gender gender)
        {
            db.Genders.Add(gender);
            return db.SaveChanges() > 0;
        }


        public bool ChangeGender(Gender gender)
        {
            var entry = db.Entry<Gender>(gender);

            entry.State = EntityState.Added;
            return db.SaveChanges() > 0;
        }

    }
}
