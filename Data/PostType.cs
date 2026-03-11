namespace ASPMustakacite.Data
{
    public class PostType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public ICollection<Post> Posts { get; set; }
        //public ICollection<Comment> Comments { get; set; }

    }
}
