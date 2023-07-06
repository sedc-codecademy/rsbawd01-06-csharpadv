namespace AbstractionExercise
{
    class Teacher : User, ITeacher
    {
        public string Subject { get; set; }

        public override void PrintUser()
        {
            base.PrintUser();
            Console.WriteLine($"Subject: {Subject}");
        }
    }
}