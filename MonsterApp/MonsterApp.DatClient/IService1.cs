using MonsterApp.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MonsterApp.DatClient
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<GenderDAO> GetGenders();

        [OperationContract]
        List<MonsterTypeDAO> GetMonsterTypes();

        [OperationContract]
        List<TitleDAO> GetTitles();
    }
}
