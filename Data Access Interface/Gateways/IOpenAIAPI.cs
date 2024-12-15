using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessInterface.Gateways
{
    public interface IOpenAIAPI
    {
        Task<string> GenerateText(string prompt, int max_tokens = 1000);
        Task<string[]> GetVectorEmbedding(string input, int max_tokens = 1000);
    }
}
