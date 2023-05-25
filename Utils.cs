using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMemorizeNumbers
{
    internal class Utils
    {
        public static float Comparison(List<RandomNumber> aList, List<RandomNumber> bList)
        {
            int coincidences = 0;
            List<RandomNumber> intrList = bList;

            for (int i = 0; i < aList.Count; i++)
            {
                if (intrList.Count > 0) { 
                    int j = -1;
                    for (int k = 0; k < intrList.Count; k++)
                        if (aList[i].Value == intrList[k].Value)
                            j = k;

                    if (j > -1)
                    {
                        coincidences++;
                        intrList.RemoveAt(j);
                    }
                }
            }

            float accuracy = (float)coincidences / aList.Count;
            if (bList.Count > aList.Count)
                accuracy *= (float)aList.Count / bList.Count;
            return accuracy;
        }
    }
}
