namespace ArshinGroup.Domain.Models.Abstractions.BaseEntities
{
    public class BaseOrderInfo : BaseContentInfo
    {
        public string DescriptionRU { get; set; }
        public string DescriptionEN { get; set; }
        public string DescriptionZH { get; set; }
        public int Price { get; set; }
        public string PriceCurrency { get; set; }

    }
}
