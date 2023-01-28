using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub
{
    public class Player
    {
        private string _name { get; set; } = null!;
        public string Name { get
            {
                return _name;
            }
            set { _name = value; }
        }
        public int Points { get; set; }
        
    }
}
