namespace Console_Client
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using GameObjects.Contracts.Engine;
    using GameObjects.Engine.Factories;
    using GameObjects.Engine;

    public class EntryPoint
    {
        public static void Main(string[] args)
        {
            var manufacturerObjects = new GameObjectManufacturerEngine();

            manufacturerObjects.Start();

        }
    }
}
