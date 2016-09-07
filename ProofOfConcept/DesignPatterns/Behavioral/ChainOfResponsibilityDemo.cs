namespace ProofOfConcept.DesignPatterns.Behavioral
{
    using ChainOfResponsibility;

    public class ChainOfResponsibilityDemo
    {
        private static AbstractLoger getChainOfLoggers()
        {
            var errorLogger = new ErrorLogger(AbstractLoger.ERROR);
            var fileLogger = new FileLogger(AbstractLoger.DEBUG);
            var consoleLogger = new ConsoleLogger(AbstractLoger.INFO);

            errorLogger.SetNextLogger(fileLogger);
            fileLogger.SetNextLogger(consoleLogger);

            return errorLogger;
        }

        public static void TestChainOfResp()
        {
            var loggerChain = getChainOfLoggers();

            loggerChain.LogMessage(AbstractLoger.INFO, "This is information");
            loggerChain.LogMessage(AbstractLoger.DEBUG, "This is debug");
            loggerChain.LogMessage(AbstractLoger.ERROR, "This is error");
        }
    }
}