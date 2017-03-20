namespace Component
{
    public abstract class Food
    {
        protected Food(string foodName)
        {
            this.FoodName = foodName;
        }

        protected string FoodName { get; set; }

        public abstract void Taste(bool isGood);

        public abstract void Smell(bool isGood);
    }
}
