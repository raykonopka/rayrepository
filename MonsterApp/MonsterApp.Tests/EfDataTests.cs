using MonsterApp.DataAccess;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MonsterApp.Tests
{

  public class EfDataTests
  {
        #region Gender Tests
        [Fact]
        public void Test_GetGenders()
        {
            var data = new EfData();
            var actual = data.GetGenders();
            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_InsertGender()
        {
            var data = new EfData();
            var expected = new Gender() { GenderName = "GenderTest", Active = true };

            var actual = data.ChangeGender(expected, System.Data.Entity.EntityState.Added);

            Assert.True(actual);
        }
        #endregion


        #region Title Tests
        [Fact]
        public void Test_GetTitles()
        {
            var data = new EfData();
            var actual = data.GetTitles();
            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_InsertTitle()
        {
            var data = new EfData();
            var expected = new Title() { TitleName = "TitleTest", Active = true };

            var actual = data.ChangeTitle(expected, System.Data.Entity.EntityState.Added);

            Assert.True(actual);
        }
        #endregion


        #region Monster Type Tests
        [Fact]
        public void Test_GetMonsterType()
        {
            var data = new EfData();
            var actual = data.GetMonsterTypes();
            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_InsertMonsterType()
        {
            var data = new EfData();
            var expected = new MonsterType() { TypeName = "TypeTest", Active = true };

            var actual = data.ChangeMonsterType(expected, System.Data.Entity.EntityState.Added);

            Assert.True(actual);
        }
        #endregion


        #region Monster Tests
        [Fact]
        public void Test_GetMonster()
        {
            var data = new EfData();
            var actual = data.GetMonsters();
            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_InsertMonster()
        {
            var data = new EfData();
            var expected = new Monster() { GenderId = 1, TitleId = 1, TypeId = 1, Name = "MonsterTestName", PicturePath = "C:", Active = true };

            var actual = data.ChangeMonster(expected, System.Data.Entity.EntityState.Added);

            Assert.True(actual);
        }
        #endregion
    }
}
