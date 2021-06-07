using System;
using System.IO;

namespace LearnCS
{
    class ExceptionEx
    {
         void Main()
        {
            StreamReader strRead = null;
            StreamWriter strWrite = null;
            try
            {
                strRead = new StreamReader(@"c:\samplefile\text.txt");
                strWrite = new StreamWriter(@"c:\samplefile\text1.txt");
                //int a = Convert.ToInt32( Console.ReadLine());
                string data = strRead.ReadToEnd();
                strWrite.Write(data);
                //Console.WriteLine();
                Console.Read();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File is not found please check {0}", ex.FileName);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Stack Trace {0}", ex.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occured {0}", ex.Message);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Stack Trace {0}", ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("Finally executed");
                Console.Read();
                if (strRead != null)
                    strRead.Close();
                if (strWrite != null)
                    strWrite.Close();
            }
            Console.Read();
        }
    }
}
