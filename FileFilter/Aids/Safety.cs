using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileFilter.Aids
{
    internal static class Safety
    {
        private static object _lock = new object();

        public static void Run(Action func)
        {
            lock (_lock)
            {
                func.Invoke();
            }
        }
    }
}
