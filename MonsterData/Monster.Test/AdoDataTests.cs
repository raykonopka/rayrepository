using MonsterApp.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Monster.Test
{
    public partial class AdoDataTests
    {
        [Fact]
        public void Test_GetGenders()
        {
            AdoData data = new AdoData();
            var actual = data.GetGenders();

            Assert.NotNull(actual);
        }
    }
}
