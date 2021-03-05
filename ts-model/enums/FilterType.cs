using System.ComponentModel;

namespace trifenix.connect.ts_model.enums
{
    public enum FilterType
    {
        [Description("Igual a")]
        EQUAL = 0,
        [Description("Contiene")]
        CONTAINS = 1,
        [Description("Mas de")]
        MORE_THAN = 2,
        [Description("Menos de")]
        LESS_THAN = 3

    }

    public enum Validation {

        [Description("Sin Validación")]
        NOVALIDATION = 0,
        [Description("Requerido")]
        REQUIRED = 1,
        [Description("único")]
        UNIQUE = 2,
        [Description("Referencia")]
        REFERENCE = 3,
        [Description("Compleja")]
        Complex = 4,
    }
}




