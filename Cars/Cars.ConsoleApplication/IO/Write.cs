namespace Cars.ConsoleApplication.IO
{
    using System;
    using Interfaces;

    public class Write : IWrite
    {
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}