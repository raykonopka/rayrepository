using MonsterApp.DataAccess;
using Models = MonsterApp.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MonsterApp.Tests
{
  public partial class AdoDataTests
  {
    private Models.Gender gender;

    public AdoDataTests()
    {
      gender = new Models.Gender() { Name = "TestGender" };
    }

    [Fact]
    public void Test_InsertGender()
    {
      var data = new AdoData();
      var actual = data.InsertGender(gender);

      Assert.True(actual);
    }
  }
}
