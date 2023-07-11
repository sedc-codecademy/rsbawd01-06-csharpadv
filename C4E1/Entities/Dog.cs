namespace Exercise.Entities
{
	public class Dog : Pet
	{
		public bool GoodBoi { get; set; }
		public string FavoriteFood { get; set; }
		public Dog(string name, int age, bool goodBoi, string favoriteFood) : base(name, age)
		{
			GoodBoi = goodBoi;
			FavoriteFood = favoriteFood;
			Type = "Dog";
		}
		public override string PrintInfo()
		{
			string isGoodBoi = GoodBoi ? "very good boi" : "not a good boi";
			return $"[{Type}] {Name} and is {isGoodBoi}! It also likes {FavoriteFood}.";
		}
	}
}
