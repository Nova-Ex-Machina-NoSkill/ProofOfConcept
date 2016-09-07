using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProofOfConcept.DesignPatterns.Behavioral.ChainOfResponsibility
{
    public abstract class AbstractLoger
    {
        public static int INFO { get { return 1; } }
        public static int DEBUG { get { return 2; } }
        public static int ERROR { get { return 3; } }

        protected int level;

        protected AbstractLoger nextLogger;

        public void SetNextLogger(AbstractLoger nextLogger)
        {
            this.nextLogger = nextLogger;
        }

        public void LogMessage(int level, string message)
        {
            if (this.level <= level) write(message);
            if (nextLogger != null) nextLogger.LogMessage(level, message);
        }

        abstract protected void write(string message);
    }
}
