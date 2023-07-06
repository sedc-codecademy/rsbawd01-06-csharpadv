namespace AbstractionExercise
{
    class Student : User, IStudent
    {
        public string Grades { get; set; }

        public override void PrintUser()
        {
            base.PrintUser();
            Console.WriteLine($"Grades: {Grades}");
        }
    }
}