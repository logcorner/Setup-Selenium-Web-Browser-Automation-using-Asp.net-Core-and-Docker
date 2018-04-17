using System.Collections.Generic;

namespace SetupSeleniumeDocker.UI.DataModel
{
    public partial class Blogs
    {
        public Blogs()
        {
            Posts = new HashSet<Posts>();
        }

        public int BlogId { get; set; }
        public string Owner { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }

        public AspNetUsers OwnerNavigation { get; set; }
        public ICollection<Posts> Posts { get; set; }
    }
}