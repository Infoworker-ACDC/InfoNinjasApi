using InfoNinjasApi.Features.NinjaFeatures;

namespace InfoNinjasApi.Data.Seeds
{
    public class SeedNinjas
    {
        public SeedNinjas(ApiContext context)
        {
            SeedNinja(context);
        }

        private static void SeedNinja(ApiContext context)
        {
            var checkIfEmptyOrNot = context.NinjaItems.FirstOrDefault();
            if (checkIfEmptyOrNot != null) return;

            var ninjas = new NinjaItem[]
            {
                new NinjaItem{ Name = "Raymond", Birthday = DateTime.Now },
                new NinjaItem{ Name = "Hussain", Birthday = DateTime.Now }
            };

            foreach(var ninja in ninjas)
            {
                context.NinjaItems.Add(ninja);
            }

            context.SaveChanges();
        }
    }
}
