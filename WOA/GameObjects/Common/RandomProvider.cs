namespace GameObjects.Common
{
    using System;

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
