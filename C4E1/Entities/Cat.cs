namespace Exercise.Entities
{
	public class Cat : Pet
	{
		public bool Lazy { get; set; }
		public int LivesLeft { get; set; }

		public Cat(string name, int age, bool lazy, int lives) : base(name, age)
		{
			Lazy = lazy;
			LivesLeft = lives;
			Type = "Cat";
		}
		public override string PrintInfo()
		{
			string isLazy = Lazy ? "very Lazy" : "not Lazy";
			return $"[{Type}] {Name} and is {isLazy}!";
		}
	}
}
