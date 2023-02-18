using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;
using System.Threading;

namespace Ch07Ex01BR
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = { 1, 2, 3, 4, 7, 4, 2, 7, 3, 7, 8, 3, 9, 1, 9, 50 };
            int maxVal = Maxima(testArray, out int[] maxValIndices);

            Console.WriteLine($"Maximum value {maxVal} found at element indices:");
            foreach (int index in maxValIndices)
            {
                Console.WriteLine(index);
            }
            Console.ReadKey();
        }

        static int Maxima(int[] integers, out int[] indices)
        {
            Debug.WriteLine("Maximum value search started.");
            indices= new int[1];
            int maxVal = integers[0];
            indices[0] = 0;
            int count = 1; // instead of the Debug.WriteLine() below, here we could set a tracepoint

            Debug.WriteLine(string.Format($"Maximum value initialized to {maxVal}, at element index 0."));



            for (int i = 0; i < integers.Length; i++)
            {
                Debug.WriteLine(string.Format($"Now looking at element at index {i}."));
                if (integers[i] > maxVal)
                {
                    maxVal= integers[i];
                    count = 1;
                    indices = new int[1];
                    indices[0] = i;
                    Debug.WriteLine(string.Format($"New Maximum Found. New value is {maxVal}, at " + $"element index{i}."));
                }
                else
                {
                    if (integers[i] == maxVal)
                    {
                        count++;
                        int[] oldIndices = indices;
                        indices = new int[count];

                        oldIndices.CopyTo(indices, 0);
                        indices[count - 1] = i;
                        Debug.WriteLine(string.Format($"Duplicate maximum found at element index {i}"));
                    }
                }
            }

            Trace.WriteLine(string.Format($"Maximum value {maxVal} found, with {count} occurrences."));
            Debug.WriteLine("Maximum value search completed.");

            Console.WriteLine($"Maximum value {maxVal} found, with {count} occurrences.");

            // We can also use a tdd approach:
            Trace.Assert(maxVal < 10, $"maxVal value {maxVal} out of bounds.", "Please contact the Marvin Team with the error code BR549.");

            return maxVal;



            // HOWEVER:
            // As per Microsoft docs here: https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.debug.assert?view=netframework-4.8

            // A console application will not show the popup as with a web app, only outputs this info to the output window

            //////////////////////////////////////////////////////////////////////

            /* Notes:

            Tracepoints have no equivalent to the Trace commands; This means that there is no way to output info in a release build using tracepoints, because tracepints are not included in the actual application. They are only available by VS locally.

            One advantage: additional info can be added to the tracepoint using $FUNCTION, which adds the current function name to the  output message.

            !! Diagnostics output—Use when debug output is something you always want to output from an application, particularly when the string you want to output is complex, involving several variables or a lot of information. In addition, Trace commands are often the only option should you want output during execution of an application built in release mode.

            Tracepoints—Use these when debugging an application to quickly output important information that may help you resolve semantic errors. Debugging in Break Mode The rest of the debugging techniques described in this chapter work in break mode. This mode can be entered in several ways, all of which result in the program pausing in some way. 

            Entering Break Mode-  The simplest way to enter break mode is to click the Pause button in the IDE while an application is running. This Pause button is found on the Debug toolbar, which you should add to the toolbars that appear by default in Visual Studio. To do this, right-click in the toolbar area and select Debug. Figure 7-6 shows the Debug toolbar that appears.





           */

        }

    }
}
