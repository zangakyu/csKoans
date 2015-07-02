using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest
{
    public class Nombres
    {
        private IEnumerable<KeyValuePair<string, int>> KeyValuePairs { get; set; }
        private IEnumerable<int> _nombresPairs;
        public String _texteNombresImpairs;

        public Nombres(IEnumerable<KeyValuePair<string, int>> keyValuePairs)
        {
            KeyValuePairs = keyValuePairs;
        }

        public IEnumerable<int> NombresPairs
        {
            get
            {
       
                return KeyValuePairs.Where( x => x.Value%2 == 0 ).Select(x => x.Value);
            }
        }

        public string TexteNombresImpairs
        {
            get
            {
                return KeyValuePairs.Where(x => x.Value % 2 != 0).OrderBy(x => x.Value).Select(x => x.Key).Aggregate((i,j) => i + ", "+ j);
            }
        }

 
    }
}
