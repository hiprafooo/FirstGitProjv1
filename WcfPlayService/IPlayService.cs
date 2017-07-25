using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfPlayService
{
    [ServiceContract]
    public interface IPlayService
    {
        [OperationContract]
        void InsertUserGameRecord(int GameId, string UserId, string HoursPlayed);
    }
}
