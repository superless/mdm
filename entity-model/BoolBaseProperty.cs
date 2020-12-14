namespace trifenix.connect.mdm.entity_model
{
    /// <summary>
    /// Implementación para tests.
    /// </summary>
    public class BoolBaseProperty : IBoolProperty
    {

        /// <summary>
        /// índice de la propiedad
        /// </summary>
        /// <value></value>
        public int index { get; set; }

        /// <summary>
        /// valor de la propiedad
        /// </summary>
        /// <value></value>
        public bool value { get; set; }


        /// <summary>
        /// facet de la propiedad
        /// </summary>
        /// <value></value>
        public string facet { get; set; }
    }
}