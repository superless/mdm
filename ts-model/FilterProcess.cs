namespace trifenix.connect.mdm.ts_model
{

    /// <summary>
    /// Elemento con la documentación de cada filtro 
    /// existe a través del atributo y elemento de metadatos ToPeocess
    /// </summary>
    public class FilterProcess
    {

        /// <summary>
        /// Índice del filtro, usado con el atributo ToProcess
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// Corresponde a la descripción del item de la enumeración fuente.
        /// </summary>
        public string EnumDescription { get; set; }


        /// <summary>
        /// Nombre del item de la enumeración fuente.
        /// </summary>
        public string EnumName { get; set; }


    }
}
