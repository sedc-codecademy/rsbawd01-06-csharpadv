namespace Exercise.Entities
{
	public abstract class Pet
	{
		public string Name { get; set; }
		public string Type { get; set; }
		public int Age { get; set; }
		public abstract string PrintInfo();
		public Pet(string name, int age)
		{
			Name = name;
			Age = age;
		}
	}
}
