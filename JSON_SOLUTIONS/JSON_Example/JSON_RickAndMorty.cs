using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_Example
{
    class JSON_RickAndMorty
    {
        public Info info { get; set; }
        public List<Character> results { get; set; }

    }

    public class Chararter
    {
        int id { get; set; }
        string name { get; set; }
        string image { get; set; }



        public override string ToString()
        {
            return name ;
           
        }
    }

   public class Info
    {
        public int count { get; set; }
        public int pages { get; set; }
        public string next { get; set; }
        public string prev { get; set; }
    }
}
