using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Services
{
    public class MadLibServices : IMadLibServices
    {

        public string MadLib(string word1, string word2, string word3, string word4, string word5, string word6, string word7, string word8, string word9, string word10)
        {
            string madlib = $"Bats are so cool! They are {word1}, {word2} animals which have wings. They like to fly around at {word3} which makes some people scared of them. But bats are {word4}, and they don't want to hurt people. I have a pet bat that lives in {word5}. I like to feed him {word6} and {word7}. He likes to {word8}. I am his favorite person, but he also likes {word9}. I want to convince my parents to get me {word10} more bats.";
            return madlib;
        }
    }
}