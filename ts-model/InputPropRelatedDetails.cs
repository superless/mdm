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
        /// Declara si el input es de referencia o contiene los valores de ingreso.
        /// </summary>
        public bool IsReference { get; set; }
    }


}
