using System.ComponentModel;

namespace trifenix.connect.ts_model.enums
{
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




