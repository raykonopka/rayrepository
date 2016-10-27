﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterApp.DataAccess
{
    public partial class AdoData
    {
        public bool InsertGender(Gender gender)
        {
            var n = new SqlParameter("name", gender.GenderName);
            var query = "INSERT INTO Monster.Gender(GenderName, Active) VALUES (@name, 1)";

            return InsertData(query, n) == 1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name = "query"></param>
        /// <param name = "parameters"></param>
        /// <returns></returns>        
        private int InsertData(string query , params SqlParameter[] parameters)
        {
            int result;

            using (var connection = new SqlConnection(connectionString))
            {
                var cmd = new SqlCommand(query, connection);

                connection.Open();
                cmd.Parameters.AddRange(parameters);
                result = cmd.ExecuteNonQuery();
            }

            return result;
        }
    }
}
