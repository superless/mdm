namespace trifenix.connect.mdm.ts_model
{
    /// <summary>
    /// Ruta para llegar al valor, por ejemplo, desde cost-center a idSeason.
    /// </summary>
    public class ToValue : ToProcessClass
    {

        
        /// <summary>
        /// Clase a llegar, ej : Barrack
        /// </summary>
        public string ValueClass { get; set; }


        /// <summary>
        /// índice de la clase, para usarlo en la consulta.
        /// </summary>
        public int ValueIndex { get; set; }

        /// <summary>
        /// nombre de la clase original o ruta del filtro.
        /// </summary>
        public string OriginClass { get; set; }


        /// <summary>
        /// Índice del elemento original
        /// </summary>
        public int OriginIndex { get; set; }

    }
}
