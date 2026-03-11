namespace ASPMustakacite.Data
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool Status { get; set; }
        public ICollection<Post> Posts { get; set; }

    }
}
