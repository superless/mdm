namespace trifenix.connect.mdm.ts_model
{
    /// <summary>
    /// Detalles de una propiedad related
    /// </summary>
    public class InputPropRelatedDetails : RelatedPropertyMetadata
    {  
        /// <summary>
        /// Nombre del mismo campo en el modelo.
        /// </summary>
        public string ModelPropName { get; set; }


        /// <summary>
        /// Nombre de la clase input
        /// </summary>
        public string ClassInput { get; set; }


        /// <summary>
        /// nombre de la clase Input Target
        /// </summary>
        public string ClassInputTarget { get; set; }


    }


}
