namespace FishTank
{
    public class Tank
    {
        public Fish[]? FishList;

        public void AddFish(Fish[] list)
        {
            FishList = list;
        }

        public decimal Feed()
        {
            decimal totalFood = 0;

            if (FishList == null)
            {
                return totalFood;
            }

            foreach (Fish fish in FishList)
            {
                totalFood += fish.RequiredFood;
            }

            return totalFood;
        }
    }
}
