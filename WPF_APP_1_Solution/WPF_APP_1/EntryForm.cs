using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_APP_1
{
    class EntryForm
    {
        public string Name;
        public string Address;
        public int ZipCode;

        public EntryForm()
        {
            this.Name = string.Empty;
            this.Address = string.Empty;
            this.ZipCode = 555;
        }
        public EntryForm(string address, string name, int zipCode)
        {
            this.Name = name;
            this.Address = address;
            this.ZipCode = zipCode;
        }

        public override string ToString()
        {
            string NF = ($"{Name},{Address}, {ZipCode}");
            return NF;
        }
    }
}
