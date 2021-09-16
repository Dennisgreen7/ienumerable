using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shior7Work
{
    public class HezkaUntil10 : IEnumerable<Double>
    {
        public int num { get; set; }

        public HezkaUntil10(int num)
        {
            this.num = num;
        }

        public IEnumerator<Double> GetEnumerator()
        {
            Double res;
            for (int i = 1; i <= 10; i++)
            {
                res = Math.Pow(this.num, i);
                yield return res;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
