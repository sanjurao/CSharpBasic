using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    //Hacker rank airwatch 
    //Move array based on the direction - left right up and dowm
    public class MoveArrayPositionByDirection
    {

        
        public MoveArrayPositionByDirection()
        {
            
        }


        public static int max(int matrixSize, List<string> cmds)
        {
            int[,] inpArr = new int[matrixSize, matrixSize];
            int count = 0;

            for (int Row = 0; Row < matrixSize; Row++)
            {

                for (int Col = 0; Col < matrixSize; Col++)
                {
                    inpArr[Row, Col] = count;
                    count += 1;
                }
            }

            int row = 0, col = 0;
            int res = inpArr[row, col];
            foreach (var item in cmds)
            {

                if (item.ToLower() == "right")
                {
                    if (col < matrixSize)
                        col = col + 1;

                }
                else if (item.ToLower() == "left")
                {
                    if (col > 0)
                        col = col - 1;

                }
                else if (item.ToLower() == "up")
                {
                    if (row > 0)
                        row = row - 1;

                }
                else if (item.ToLower() == "down")
                {
                    if (row < matrixSize)
                        row = row + 1;

                }

                res = inpArr[row, col];



            }
            return res;

        }


    }
}
