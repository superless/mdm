using System.Collections.Generic;

namespace trifenix.connect.mdm.ts_model
{
    /// <summary>
    /// Metadata completo del modelo.
    /// </summary>
    public class ModelMetaData {

        /// <summary>
        /// Versión de la metadata.
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Coleccion de metadata de cada entidad del modelo
        /// </summary>
        public EntityMetadata[] Indexes { get; set; }

        /// <summary>
        /// Descripciones de enumeraciones útiles.
        /// </summary>
        public EnumDescription[] EnumDescriptions { get; set; } = new EnumDescription[] { };
    }


    /// <summary>
    /// Descripción de enumeración
    /// </summary>
    public class EnumDescription {

        /// <summary>
        /// Nombre de la enumeración
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Descripciones de cada item de una enumeración.
        /// </summary>
        public ItemEnumDescription[] Descriptions { get; set; } = new ItemEnumDescription[] { };
    }


    /// <summary>
    /// descripción de un item de enumeración.
    /// </summary>
    public class ItemEnumDescription {

        /// <summary>
        /// índice de una enumeración
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// Descripción de una enumeración, encontrado en el parámetro Description o el nombre del item de la enumeración.
        /// </summary>
        public string Description { get; set; }
    }
}
