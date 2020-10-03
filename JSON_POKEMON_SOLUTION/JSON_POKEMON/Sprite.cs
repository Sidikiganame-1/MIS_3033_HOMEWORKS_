using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_POKEMON
{
    class PokemonInfo
    {
        public int Weight { get; set; }
        public int Height { get; set; }

        public Sprite Sprites { get; set; }
       
    }

    public class Sprite
    {
         public string back_default { get; set; }
          public string front_default { get; set; }
    }
}
