namespace Cars.ConsoleApplication.IO
{
    using System;
    using Interfaces;

    public class Read : IRead
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
