namespace FishTank
{
    public class BabelFish : Fish
    {
        public BabelFish(string name) : base(name)
        {
            RequiredFood = (decimal)0.3;
        }
    }
}
