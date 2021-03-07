﻿using System;
using trifenix.connect.mdm.enums;

namespace trifenix.connect.mdm_attributes
{
    /// <summary>
    /// Determina el pathname que será usado en la clase y
    /// el tipo de entidad.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class EntityIndexAttribute : BaseIndexAttribute {
        /// <summary>
        /// determina un pathname que puede ser usado en el router del cliente
        /// o en la url de la api rest.
        /// </summary>
        public string PathName { get; set; }

        /// <summary>
        /// Determina el tipo de entidad.
        /// Si es de tipo entity, significa que es lo suficientemente simple para generar su formulario
        /// de manera automática,
        /// si es de´tipo proceso, se identificará como documento o proceso.
        /// y si es custom, se entenderá que puede no ser un proceso, pero debe ser construido manualmente.
        /// </summary>
        public EntityKind Kind { get; set; }


        /// <summary>
        /// Determina si es globalFilter
        /// </summary>
        public bool IsGlobalFilter { get; set; }


    }

}
