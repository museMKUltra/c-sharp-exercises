using System;

namespace ConsoleApplication1.Extensibility
{
    public interface ILogger
    {
        void LogError(string message);
        void LogInfo(string message);
    }
}