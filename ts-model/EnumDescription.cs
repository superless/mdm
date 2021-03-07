namespace trifenix.connect.mdm.ts_model
{
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
}
