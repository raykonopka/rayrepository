using MonsterApp.DataAccess;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterApp.DataAccess
{
    public partial class AdoData
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MonsterDBConnectionString"].ConnectionString;


        #region Methods
        ///<summary>
        ///
        ///</summary>
        ///<returns></returns>
        public List<Gender> GetGenders()
        {
        
            try
            {
                var ds = GetDataDisconnected("SELECT * FROM Monster.Gender;");
                var genders = new List<Gender>();

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    genders.Add(new Gender()
                    {
                        GenderId = int.Parse(row[0].ToString()),
                        Name = row[1].ToString(),
                        Active = bool.Parse(row[2].ToString())
                    });
                }

                return genders;
            }

            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return null;
            }
        }


        ///<summary>
        ///
        ///</summary>
        ///<returns></returns>
        public List<MonsterType> GetMonsterTypes()
        {
            throw new NotImplementedException("not ready yet");
        }


        ///<summary>
        ///
        ///</summary>
        ///<returns></returns>
        public List<Title> GetTitles()
        {
            throw new NotImplementedException("not ready yet");
        }
        #endregion


        private DataSet GetDataDisconnected(string query)
        {
            SqlDataAdapter da;
            DataSet ds;
            SqlCommand cmd;

            using (var connection = new SqlConnection(connectionString))
            {
                cmd = new SqlCommand(query, connection);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();

                da.Fill(ds);
            }

            return ds;
        }
    }
}
