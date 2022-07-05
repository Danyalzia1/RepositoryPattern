using System;

namespace LibraryManagementSysAPI.ExceptionLogs
{
    public class Logger : ILogger
    {
        public void log(string err)
        {
            Console.WriteLine(err);
        }
    }
}
