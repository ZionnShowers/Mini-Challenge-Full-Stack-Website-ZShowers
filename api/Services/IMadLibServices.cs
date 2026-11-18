using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Services
{
    public interface IMadLibServices
    {
        string MadLib(string word1, string word2, string word3, string word4, string word5, string word6, string word7, string word8, string word9, string word10);
    }
}