using System;

using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace JumpingOnClouds
{
    class Program
    {


        static void Main(string[] args)
        {

            int n = 6;

           // int[] c = {0, 0, 1, 0, 0, 1, 0};

            int[] c = {0, 0, 0, 1, 0, 0} ;

            int result = jumpingOnClouds(c);

        }

        static int jumpingOnClouds(int[] c)
        {
            var totalNumberOfSteps = 0;
            //Console.WriteLine("Total Number of Clouds: " + n);


            var cloudCount = c.Count();

            var skipNext = false;
            for (int i = 0; i < cloudCount; i++)
            {

                //if number = 1 then skip altogether
                if (c[i] == 1 || skipNext)
                {
                    skipNext = false;
                    continue;
                }

                if (c[i] == 0)
                {
                    if (i + 2 < cloudCount)
                    {
                        if (CanJump2(c[i + 1], c[i + 2]))
                        {
                            skipNext = true;
                            totalNumberOfSteps += 1;
                            continue;
                        }
                    }
                }

                if (i != cloudCount-1)
                {
                    totalNumberOfSteps += 1;
                }
                
            }
            return totalNumberOfSteps;
        }


        /// <summary>
        /// Check to see if the next 2 numbers can be jumped over
        /// </summary>
        /// <param name="nextNum1"></param>
        /// <param name="nextNum2"></param>
        /// <returns></returns>
        public static bool CanJump2(int nextNum1, int nextNum2)
        {
            if (nextNum1 == 0 && nextNum2 == 0)
            {
                return true;
            }

            return false;
        }
    }
}
