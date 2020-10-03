using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_POKEMON
{
    class AllPokemonAPI
    {
        public List<PokemonResult> results { get; set; }




    }
    public class PokemonResult
    {
        public string name { get; set; }
        public string url { get; set; }

        public override string ToString()
        {
            return name[0].ToString().ToUpper() + name.Substring(1, name.Length - 1);
        }
    }

   
}

    
   
