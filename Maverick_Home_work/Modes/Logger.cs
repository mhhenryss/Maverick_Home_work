using Maverick_Home_work.Interfaces;

namespace Maverick_Home_work.Modes
{
    public class Logger : ILogger
    {
        public void Info(string message)
        {
            DebugHelper.Info(message);
        }
    }
}