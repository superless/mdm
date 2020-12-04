using System;
using System.Collections.Generic;
using System.Text;
using trifenix.connect.mdm.enums;
using trifenix.connect.mdm.ts_model;
namespace trifenix.connect.mdm.resources
{
    /// <summary>
    /// Documentación de cada elemeentos del modelo entitity search.
    /// </summary>
    public interface IMdmDocumentation {
        
        /// <summary>
        /// Obtiene información de una propiedad
        /// </summary>
        /// <param name="property">Tipo de propiedad</param>
        /// <param name="index">índice de la propiedad</param>
        /// <returns>Información de la entidad (título, descripción, nombre corto y columna )</returns>
        EntitySearchDisplayInfo GetInfoFromProperty(KindProperty property, int index);

        /// <summary>
        /// Obtiene información de una entidad.
        /// </summary>
        /// <param name="index">índice de la entidad</param>
        /// <returns>Información de la entidad (título, descripción, nombre corto y columna )</returns>
        EntitySearchDisplayInfo GetInfoFromEntity(int index);

    }
}
