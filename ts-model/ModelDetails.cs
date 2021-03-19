using System.Collections.Generic;

namespace trifenix.connect.mdm.ts_model
{
    /// <summary>
    /// otra vista de las propiedades
    /// </summary>
    public class ModelDetails {
        // <summary>
        /// Cada una de las propiedades
        /// </summary>
        public Dictionary<string, PropertyMetadata> PropsDetails { get; set; }


        /// <summary>
        /// enumeraciones
        /// </summary>
        public Dictionary<string, PropertyMetadadataEnum> PropsEnumDetails { get; set; }


        /// <summary>
        /// Cada una de las propiedades de tipo related.
        /// </summary>
        public Dictionary<string, RelatedPropertyMetadata> RelatedDetails { get; set; }

        /// <summary>
        /// Recursividad con los campos de tipo objeto con sus propias propiedades
        /// </summary>
        public Dictionary<string, ModelDetails> RelatedInputs { get; set; }
    }


}
