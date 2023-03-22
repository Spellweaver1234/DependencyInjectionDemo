using System.Diagnostics;

namespace DependencyInjection
{
    /// <summary>
    /// Этот логер просто выводит в консоль результат
    /// </summary>
    public class NullLogger : ILogger
    {
        public void WriteLine(string message)
        {
            Debug.WriteLine(message);
        }
    }
}
