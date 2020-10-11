using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quizoo.Helper
{
    public static class IgnoreException
    {
        public static void Ignore(Action ignore)
        {
            try
            {
                ignore();
            } catch { }
        }
    }
}
