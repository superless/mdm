namespace trifenix.connect.mdm.enums
{
    /// <summary>
    /// Determina si una entidad es local, es decir no tiene key value en una base de datos documental
    /// o es de referencia, por lo tanto, si tiene un key value en una base documental.
    /// </summary>
    public enum KindEntityProperty {

        ///<summary>
        /// Referecia a una entidad de la base de datos
        ///</summary>
        REFERENCE = 0,

        ///<summary>
        /// Referecia a una entidad local, es decir que es parte del objeto
        ///</summary>
        LOCAL_REFERENCE = 1,
    }
}



