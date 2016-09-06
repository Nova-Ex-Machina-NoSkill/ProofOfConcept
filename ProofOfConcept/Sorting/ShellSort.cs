using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProofOfConcept.Sorting
{
    public static class ShellSort<T> where T : IComparable
    {
        public static T[] Sort(T[] array)
        {
            var interval = 1;
            while (interval < array.Length / 3) interval = interval * 3 + 1;
            while (interval > 0)
            {
                for(var outer = interval; outer < array.Length; outer++)
                {
                    var valueToInsert = array[outer];
                    var inner = outer;
                    while(inner > interval - 1 && array[inner - interval].CompareTo(valueToInsert) >= 0)
                    {
                        array[inner] = array[inner - interval];
                        inner -= interval;
                    }
                    array[inner] = valueToInsert;
                }
                interval = (interval - 1) / 3;
            }
            return array;
        }
    }
}