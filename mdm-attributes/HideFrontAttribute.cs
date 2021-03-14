using System;

namespace trifenix.connect.mdm_attributes
{
    /// <summary>
    /// Oculta un campo.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class HideFrontAttribute : Attribute
    {
        /// <summary>
        /// Inicializa
        /// </summary>
        public HideFrontAttribute()
        {

        }

    }
}
