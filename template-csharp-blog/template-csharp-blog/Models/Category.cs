namespace template_csharp_blog.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Post Post { get; set; }
    }
}
