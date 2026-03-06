using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VHT;
    
    public class Transformer<T>{}
    
    public class MultiDelegate
    {   
        public delegate void ProgressReporter(int percentComplete);
        public static void HardWork(ProgressReporter p)
        {
            for(int i=0; i<5; ++i)
            {
                p.Invoke(i*10);
            }

            System.Threading.Thread.Sleep(100);
        }

        public void MultiCast()
        {
            ProgressReporter p = WriteProgressToConsole;
            p += WriteProgressToFile;
            p -= WriteProgressToConsole; 
            p -= WriteProgressToFile;
            HardWork(p);
        }

        public static void WriteProgressToConsole(int i) => Console.WriteLine(i);
        public static void WriteProgressToFile(int i) => System.IO.File.WriteAllText("progress.txt",i.ToString()); 
    }
