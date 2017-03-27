using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemotingService
{
    [Serializable()]
    public class FlightInfo
    {
        public string airplane_id; //飞机编号
        public short fly_type; //进出机场 1进机场 2出机场
        public string estimation_time; //预计时间
        public string ower_company; //所属机构
        public string airplane_type; //机型
    }
}
