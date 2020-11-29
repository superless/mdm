using System;
using System.Collections.Generic;

namespace trifenix.connect.mdm.containers
{
    /// <summary>
    /// Envia un Contenedor con detalles del error
    /// </summary>
    /// <typeparam name="T">Tipo de resultado que debería envíar</typeparam>
    public class ExtPostErrorContainer<T> : ExtPostContainer<T>{
        /// <summary>
        /// Excepción encontrada.
        /// </summary>
        /// <value></value>
        public Exception InternalException { get; set; }

        /// <summary>
        /// Mensajes de validación.
        /// </summary>
        private List<string> _validationMessages;

        /// <summary>
        /// Mensajes de Validación o mas bien de error.
        /// </summary>
        /// <value></value>
        public List<string> ValidationMessages {
            get {
                _validationMessages = _validationMessages ?? new List<string>();
                return _validationMessages;
            }
            set { _validationMessages = value; }
        }

        /// <summary>
        /// ExtPostContainer con los campos de este tipo
        /// </summary>
        /// <value>Tipo de resultado</value>
        public ExtPostContainer<T> GetBase => new ExtPostContainer<T>
        {
            IdRelated = IdRelated,
            Message = Message,
            MessageResult = MessageResult,
            Result = Result
        };
    }
}