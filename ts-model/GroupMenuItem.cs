namespace trifenix.connect.mdm.ts_model
{
    /// <summary>
    /// Determina el valor de un item de menú.
    /// </summary>
    public class GroupMenuItem {

        /// <summary>
        /// Ruta del link del menú.
        /// </summary>
        public string PathName { get; set; }

        /// <summary>
        /// Nombre del grupo menu item, en este caso sería el nombre de la clase, en la documentación.
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// Nombre Corto del grupo menu item, en este caso sería el nombre de la clase, en la documentación.
        /// </summary>
        public string ShortName { get; set; }



    }
}
