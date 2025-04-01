namespace CSharpInDepth.UserIdentity.Database.Entities
{
    public interface ISoftDeletable
    {
        public bool IsDeleted { get; set; }
        public DateTime DeletedOn { get; set; }
    }
}
