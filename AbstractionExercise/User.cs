﻿namespace AbstractionExercise
{
    abstract class User : IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual void PrintUser()
        {
            Console.WriteLine($"Id: {Id}\nName: {Name}\nUsername: {Username}");
        }
    }
}