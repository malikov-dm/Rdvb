using System;

namespace Rdvb.RP.Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello World!");
                RpCall.GetSoapMessageAsync().Wait();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"There was an exception: {ex.ToString()}");
            }
        }
    }
}
