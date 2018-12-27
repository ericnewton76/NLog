using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    internal static class ContractX
    {
        /// <summary>
        /// Asserts that the argument isnt null, throws ArgumentNullException if it is.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arg"></param>
        /// <param name="paramName"></param>
        /// <returns>the argument value</returns>
        public static T ArgNotNull<T>(T arg, string paramName)
        {
            if(arg == null)
            {
                throw new ArgumentNullException(paramName);
            }

            return arg;
        }

    }
}
