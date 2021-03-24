using System;

namespace DesignPatterns.SOLID.SRP
{
    public interface ILogger
    {
        void Info(string info);
        void Debug(string info);
        void Error(string message, Exception ex);
    }

    public class Logger : ILogger
    {
        public void Debug(string info)
        {
            Console.WriteLine($"Debug: {info}");
        }

        public void Error(string message, Exception ex)
        {
            Console.WriteLine($"Error: {message}, Exception: {ex}");
        }

        public void Info(string info)
        {
            Console.WriteLine($"Info: {info}");
        }
    }
}