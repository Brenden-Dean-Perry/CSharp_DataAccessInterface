using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessInterface
{
    public interface IConfig
    {
        string GetApiKeyDictonaryPath();
        string GetOpenAIKey();
        string GetOpenAIEmbeddingEndpoint();
        string GetOpenAIGenerativeTextEndpoint();
    }
}
