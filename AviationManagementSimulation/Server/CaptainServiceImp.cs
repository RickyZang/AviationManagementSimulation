using RemotingService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class CaptainServiceImp : MarshalByRefObject, ICaptainService
    {
        public string TestMethod()
        {
            return "学宇大哥你好！";
        }
    }
}
