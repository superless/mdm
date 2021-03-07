using System.Collections.Generic;

namespace trifenix.connect.mdm.ts_model
{
    /// <summary>
    /// Detalles de cada input.
    /// </summary>
    public class InputDetails {

        /// <summary>
        /// Cada una de las propiedades
        /// </summary>
        public Dictionary<string, InputPropDetails> InputPropsDetails { get; set; }


        /// <summary>
        /// Cada una de las propiedades de tipo related.
        /// </summary>
        public Dictionary<string, InputPropRelatedDetails> InputRelatedDetails { get; set; }

        /// <summary>
        /// Recursividad con los campos de tipo objeto con sus propias propiedades
        /// </summary>
        public Dictionary<string, InputDetails> RelatedInputs { get; set; }

        /// <summary>
        /// Por cada enumeración de validación, se indican el  o los nombres de campos involucrados.
        /// las validaciones actuales solo usarían un nombre.
        /// se cambia porque no es soportado por typegen
        /// </summary>
        public Dictionary<int, string[][]> ValidationsGroup { get; set; }
    }


}
