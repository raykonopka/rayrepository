using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterApp.DataAccess
{
    public partial class AdoData
    {

        public bool UpdateGender(Gender gender)
        {
            
            var name = new SqlParameter("name", gender.GenderName);
            var active = new SqlParameter("active", gender.Active ? 1 : 0);
            var genderid = new SqlParameter("genderid", gender.GenderId);
            var query = "UPDATE Monster.Gender SET GenderName = @name, Active = @active WHERE GenderId = @genderid";
            int result;

            using (var connection = new SqlConnection(connectionString))
            {
                var cmd = new SqlCommand(query, connection);

                connection.Open();
                cmd.Parameters.AddRange(new SqlParameter[] { name, active, genderid });
                result = cmd.ExecuteNonQuery();
            }

            return result >= 0;
        }
    }
}
