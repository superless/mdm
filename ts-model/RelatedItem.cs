namespace trifenix.connect.mdm.ts_model
{
    /// <summary>
    /// Indica una entidad relacionada
    /// con la estructura para llegar a una entidad en particular
    /// </summary>
    public class RelatedItem {

        /// <summary>
        /// Nombre de la clase de la entidad disponible como filtro de otra entidad
        /// </summary>
        public string ClassName { get; set; }

        /// <summary>
        /// el índice de la clase de la entidad disponible como filtro de otra entidad
        /// </summary>
        public int Index { get; set; }


        /// <summary>
        /// Ruta para llegar a la entidad desde esta.
        /// </summary>
        public ToProcessClass PathToEntity { get; set; }

        /// <summary>
        /// con el process class tiene el índice y el nombre, en filterprocess tiene la descripción.
        /// </summary>
        public DocFilter docFilter { get; set; }

    }
}
