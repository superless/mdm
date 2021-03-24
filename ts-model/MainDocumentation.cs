using System.Collections.Generic;

namespace trifenix.connect.mdm.ts_model
{
    /// <summary>
    /// Documentación principal
    /// </summary>
    public class MainDocumentation{

        /// <summary>
        /// Documentación de Strings
        /// </summary>
        public Dictionary<int, EntitySearchDisplayInfo> Strs { get; set; }

        /// <summary>
        /// Documentación de Nums
        /// </summary>
        public Dictionary<int, EntitySearchDisplayInfo> Nums { get; set; }

        /// <summary>
        /// Documentación de Geos
        /// </summary>
        public Dictionary<int, EntitySearchDisplayInfo> Geos { get; set; }

        /// <summary>
        /// Documentación de Fechas
        /// </summary>
        public Dictionary<int, EntitySearchDisplayInfo> Dates { get; set; }

        /// <summary>
        /// Documentación de booleanos
        /// </summary>
        public Dictionary<int, EntitySearchDisplayInfo> Bools { get; set; }


        /// <summary>
        /// Documentación de Enums
        /// </summary>
        public Dictionary<int, EntitySearchDisplayInfo> Enums { get; set; }


        /// <summary>
        /// Documentación de Doubles
        /// </summary>
        public Dictionary<int, EntitySearchDisplayInfo> Dbls { get; set; }

        /// <summary>
        /// Documentación de Entidades
        /// </summary>
        public Dictionary<int, EntitySearchDisplayInfo> Rels { get; set; }
    }
}
