using System;
using System.IO;

namespace dispose1
{
    public class demonstratingclass : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("The dispose() function has been called and the resources have been released!");
        }
    }
    public class demofordispose
    {
     
        public static void Main(string[] args)
        {
           
            var result = new demonstratingclass();
            
            result.Dispose();
        }
    }

    
}
