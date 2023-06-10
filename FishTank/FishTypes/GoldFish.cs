namespace FishTank
{
    public class GoldFish : Fish
    {
        public GoldFish(string name) : base(name)
        {
            RequiredFood = (decimal)0.1;
        }
    }
}
