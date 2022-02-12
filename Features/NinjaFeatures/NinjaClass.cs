namespace InfoNinjasApi.Features.NinjaFeatures
{
    public class NinjaItem
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public DateTime Birthday { get; set; }
    }

    public class NinjaItemDto
    {
        public long Id { get; set; }
        public string? Name { get; set; }
    }
}
