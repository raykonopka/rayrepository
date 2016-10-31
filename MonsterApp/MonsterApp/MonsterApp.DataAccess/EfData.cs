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
        private MonsterDBEntities db = new MonsterDBEntities();

        #region Gender Access
        public List<Gender> GetGenders()
        {
            return db.Genders.ToList();
        }

        public bool InsertGender(Gender gender)
        {
            db.Genders.Add(gender);
            return db.SaveChanges() > 0;
        }

        public bool ChangeGender(Gender gender, EntityState state)
        {
            var entry = db.Entry<Gender>(gender);

            entry.State = state;
            return db.SaveChanges() > 0;
        }

        public void SearchGender(string genderSearchTerm)
        {
            var actives = db.Genders.Where(a => a.Active);
            var inactives = db.Genders.Select(a => !a.Active);
            var ma = db.Genders.Where(m => m.GenderName.ToLower().Contains(genderSearchTerm));
        }
        #endregion


        #region Title Access
        public List<Title> GetTitles()
        {
            return db.Titles.ToList();
        }


        public bool InsertTitle(Title title)
        {
            db.Titles.Add(title);
            return db.SaveChanges() > 0;
        }

        public bool ChangeTitle(Title title, EntityState state)
        {
            var entry = db.Entry<Title>(title);

            entry.State = state;
            return db.SaveChanges() > 0;
        }

        public void SearchTitle()
        {
            var actives = db.Titles.Where(a => a.Active);
            var inactives = db.Titles.Select(a => !a.Active);
            var ma = db.Titles.Where(m => m.TitleName.ToLower().Contains("ma"));
        }
        #endregion


        #region Monster Type Access
        public List<MonsterType> GetMonsterTypes()
        {
            return db.MonsterTypes.ToList();
        }


        public bool InsertMonsterType(MonsterType monsterType)
        {
            db.MonsterTypes.Add(monsterType);
            return db.SaveChanges() > 0;
        }

        public bool ChangeMonsterType(MonsterType monsterType, EntityState state)
        {
            var entry = db.Entry<MonsterType>(monsterType);

            entry.State = state;
            return db.SaveChanges() > 0;
        }

        public void SearchMonsterType()
        {
            var actives = db.MonsterTypes.Where(a => a.Active);
            var inactives = db.MonsterTypes.Select(a => !a.Active);
            var ma = db.MonsterTypes.Where(m => m.TypeName.ToLower().Contains("ma"));
        }
        #endregion


        #region Monster Access
        public List<Monster> GetMonsters()
        {
            return db.Monsters.ToList();
        }

        public bool InsertMonster(Monster monster)
        {
            db.Monsters.Add(monster);
            return db.SaveChanges() > 0;
        }

        public bool ChangeMonster(Monster monster, EntityState state)
        {
            var entry = db.Entry<Monster>(monster);

            entry.State = state;
            return db.SaveChanges() > 0;
        }

        public void SearchMonster()
        {
            var actives = db.Monsters.Where(a => a.Active);
            var inactives = db.Monsters.Select(a => !a.Active);
            var ma = db.Monsters.Where(m => m.Name.ToLower().Contains("ma"));
        }
        #endregion
    }
}
