using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shior7Work
{
    class SidraAd100 : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            for (int i = 1; i < 11; i++)
            {
                yield return i*10;
            }
        }
    }
}
