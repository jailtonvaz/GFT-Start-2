namespace GFT_Start_2.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string _name, int _level, string _heroType) : base(_name, _level, _heroType) {}

        public override string Attack()
        {
            return $"{this.Name} lançou magia.";
        }
    }
}