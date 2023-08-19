class User
{
    public string Name { get; set; }
    public string Email { get; set; }
    public List<Book> CheckedOutBooks { get; set; } = new List<Book>();
}
