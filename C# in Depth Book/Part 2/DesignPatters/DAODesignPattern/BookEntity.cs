namespace Part2.DesignPatters.DAODesignPattern
{
    public class BookEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime PublicationYear { get; set; }
        public string AuthorName { get; set; }
        public int ViewsCount { get; set; }
    }
}