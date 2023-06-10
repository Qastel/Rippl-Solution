namespace FishTank
{
    public class AngelFish : Fish
    {
        public AngelFish(string name) : base(name)
        {
            RequiredFood = (decimal)0.2;
        }
    }
}
