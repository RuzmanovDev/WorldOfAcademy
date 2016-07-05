using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObjects.Common
{
    public static class RandomProvider
    {
        private static Random instance;

        /// <summary>
        /// The instance of the random class
        /// </summary>
        /// <value>
        /// The instance of the random class
        /// </value>
        public static Random Instance => instance ?? (instance = new Random());
    }
}
