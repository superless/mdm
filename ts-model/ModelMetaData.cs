using trifenix.versions.model;

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
        /// Información detallada de la historia de versiones.
        /// </summary>
        public VersionStructure VersionStructure { get; set; }


        /// <summary>
        /// Coleccion de metadata de cada entidad del modelo
        /// </summary>
        public EntityMetadata[] Indexes { get; set; }


        /// <summary>
        /// Estructura de Filtros globales, indicando de que manera
        /// llegar a el proceso principal del filtro (Barracks).
        /// </summary>
        public  GlobalFilters GlobalFilters { get; set; }

        /// <summary>
        /// Descripciones de enumeraciones útiles.
        /// </summary>
        public EnumDescription[] EnumDescriptions { get; set; } = new EnumDescription[] { };

        /// <summary>
        /// Documentación principal, repositorio de documentación de cada índice
        /// </summary>
        public MainDocumentation MainDocumentation { get; set; }


        /// <summary>
        /// Menú generado con la metadata.
        /// </summary>
        public GroupMenuViewer[] Menu { get; set; }

    }
}
