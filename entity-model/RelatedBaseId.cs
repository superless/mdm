namespace trifenix.connect.mdm.entity_model
{
    public class RelatedBaseId : IRelatedId
    {
        public string facet { get => $"{index},{id}"; }
        public int index { get; set; }
        public string id { get; set; }
    }
}