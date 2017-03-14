using System.Text;

namespace PostsAndTasksConsoleApp.Domain
{
    public class PostValidator : IValidator<Post>
    {
        public void Validate(Post post)
        {
            StringBuilder err = new StringBuilder();
            if (post.Id < 0)
                err.Append("Id nu poate fi negativ!\n");
            if (post.Name == "")
                err.Append("Numele nu poate fi vid!\n");
            if (post.Type == "")
                err.Append("Tipul nu poate fi vid!\n");

            if (err.Length != 0)
                throw new ValidationException(err.ToString());
        }
    }
}
