namespace SOLID
{
    class FileLogger
    {
        public void Handle(Exception ex)
        {
            File.WriteAllText(@"C:\Error.txt", ex.Message);
        }
    }
}
