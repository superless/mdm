namespace trifenix.connect.mdm.ts_model
{
    /// <summary>
    /// Representa un item de menú y sus links.
    /// </summary>
    public class GroupMenuViewer 
    {
        /// <summary>
        /// Nombre del menú raíz.
        /// ej: mantenedores.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Colección de items de menú.
        /// </summary>
        public GroupMenuItem[] Items { get; set; }

        /// <summary>
        /// Sub Menús.
        /// </summary>
        public GroupMenuViewer[] GroupMenu { get; set; }
    }
}
