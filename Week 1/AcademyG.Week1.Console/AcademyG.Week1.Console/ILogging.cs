using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyG.Week1.Console
{
    public interface ILogging
    {
        void LogInfo(string messaggio);
        void LogWarning(string messaggio);
        void LogError(string messaggio);

    }
}
