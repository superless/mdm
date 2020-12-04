using System;

using System.Text;

namespace trifenix.connect.mdm_attributes
{

    /// <summary>
    /// atributo base de entitySearch
    /// </summary>
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    public class BaseIndexAttribute : Attribute
    {
        /// <summary>
        /// Índice de la propiedad.
        /// </summary>
        public int Index { get;  set; }

        /// <summary>
        /// determina si la propiedad es visible.
        /// </summary>
        public bool Visible { get; set; } = true;

        /// <summary>
        /// determina si la entidad es una entidad.
        /// </summary>
        public bool IsEntity { get; protected set; }

        /// <summary>
        /// índice del tipo de  propiedad
        /// tendrá distintos indices si es entidad u propiedad.
        /// </summary>
        public int KindIndex { get; set; }
    }
}
