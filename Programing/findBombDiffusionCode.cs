using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    public class findBombDiffusionCode
    {
        public static List<int> findBombDiffusion(int size, int key, int[] message)
        {
            // WRITE YOUR CODE HERE
            List<int> res = new List<int>();

            //for (int i = 0; i < size; i++)
            //{
            //    int total = 0, ct = 0;
            //    for (int j = i + 1; j < message.Length; j++)
            //    {
            //        ct = ct + 1;
            //        total = total + message[j];
            //    }
            //    if (ct != key)
            //    {
            //        for (int k = 0; k < key-ct; k++)
            //        {
            //            total = total + message[k];                        
            //        }

            //    }
            //    res.Add(total);

            //}

            for (int i = 0; i < size; i++)
            {
                int total = 0;
                for (int j = 0; j < key; j++)
                {
                    try
                    {
                        int len = i + 1 + j, count = 0;
                        if (len < message.Length)
                            total += message[len];
                        else
                        {
                            total += message[count];
                            count++;
                        }
                    }
                    catch (Exception e)
                    {

                    }
                }
                //if (ct != key)
                //{
                //    for (int k = 0; k < key - ct; k++)
                //    {
                //        total = total + message[k];
                //    }

                //}
                res.Add(total);

            }

            return res;

        }   
    }
}
