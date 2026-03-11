namespace ASPMustakacite.Data
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
        public string ClientId { get; set; }
        public Client Clients { get; set; }
        public DateTime RegistrationDate { get; set; }

    }
}
