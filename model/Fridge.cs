using System;
using System.Collections.Generic;
using System.Text;

namespace oop.model
{
    /// <summary>
    /// Hűtőszekrény
    /// </summary>
    class Fridge
    {
        /// <summary>
        /// Raktáros
        /// </summary>
        private string storekeeper;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="storekeeper">A hűtőszekrészt bevételező vagy kiadó raktáros</param>
        public Fridge(string storekeeper)
        {
            this.storekeeper = storekeeper;
        }

        /// <summary>
        /// Hűtőszekrész bevételezése a raktárba
        /// </summary>
        public string TakesToWarehouse()
        {
            return storekeeper + " bevételez egy hűtőszekrényt a raktárba.";
        }
        /// <summary>
        /// Hűtőszekrész kiadása a raktárból
        /// </summary>
        public string GoOutFromWarehouseString()
        {
            return storekeeper + " kiad egy hűtőszekrényt a raktárból.";
        }
    }
}

