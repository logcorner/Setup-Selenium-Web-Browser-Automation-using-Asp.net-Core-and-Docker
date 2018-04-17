namespace SetupSeleniumeDocker.UI.DataModel
{
    public partial class Posts
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int BlogId { get; set; }

        public Blogs Blog { get; set; }
    }
}