using InfoNinjasApi.Data.Seeds;

namespace InfoNinjasApi.Data
{
    public static class DbInitializer
    {
        private static SeedNinjas _seedNinjas;

        public static void InitializeStandard(ApiContext context)
        {
            _seedNinjas = new SeedNinjas(context);
        }
    }
}
