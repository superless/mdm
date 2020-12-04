
namespace trifenix.connect.mdm_attributes
{
    /// <summary>
    /// Atributos de trifenix connect,
    /// los atributos permitirán asignar la metadata, para la centralización.
    /// # AutoNumericDependantAttribute
    /// Cuando se asigna este atributo, el campo que lo tenga generará una autonumeración dependiente de otra entidad.
    /// por ejemplo, una factura, el autonumérico de los productos relacionados, avanzará solo por la id de la factura.
    /// # BaseIndexAtribute
    /// Tiene los principales atributos para la identificación de una propiedad de un entitySearch}
    /// * **índice**, índica el número entero que lo representa (Cada clase y cada propiedad del modelo se relaciona a este índice).
    /// * **visible**, determina si el campo es o no visible en el modelo entitySearch.
    /// * **isEntity**, determina si la propiedad representa una entidad, es es una entidad la propiedad tendrá el identificador y el índice de esta.
    /// * **kindIndex**, determina el tipo de índice
    ///</summary>
    internal class Namespace
    {}
}