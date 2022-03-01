namespace GFT_Start_2.src.Entities
{
    public class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }

        public Hero(string _name, int _level, string _heroType)
        {
            this.Name = _name;
            this.Level = _level;
            this.HeroType = _heroType;
        }
        
        public override string ToString()
        {
            return $"{this.Name} | {this.Level} | {this.HeroType}";
        }

        public virtual string Attack()
        {
            return $"{this.Name} atacou com sua espada.";
        }
    }
}