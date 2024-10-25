using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingZerosToTheEndKata
{
    public class MovingZeros
    {
        public static int[] MoveZeros(int[] arr)
        {
            var outcome = new List<int>();
            var zeros = new List<int>();
            for(var i=0; i<arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    outcome.Add(arr[i]);
                }
                else
                {
                    zeros.Add(arr[i]);
                }
            }
            outcome.AddRange(zeros);
            return outcome.ToArray();
        }
    }
}
