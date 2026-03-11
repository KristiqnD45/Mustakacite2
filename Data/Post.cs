namespace ASPMustakacite.Data
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImageURL { get; set; }
        public int PostTypeId { get; set; }
        public PostType PostTypes { get; set; }
        public int CategoryId { get; set; }
        public Category Categoryes { get; set; }
        public DateTime RegistrationDate { get; set; }
        public ICollection<Comment> Comments { get; set; }

    }
}
