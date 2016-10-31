using MonsterApp.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MonsterApp.DataClient
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<GenderDAO> GetGenders();
        [OperationContract]
        List<MonsterTypeDAO> GetMonsterTypes();

        [OperationContract]
        [WebInvoke]
        List<TitleDAO> GetTitles();
    }
}
