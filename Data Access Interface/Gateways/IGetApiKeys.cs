using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessInterface.Gateways
{
    public interface IGetApiKeys
    {
        Dictionary<string, string> GetData();
    }
}
