using QuizApplication.Data;

namespace QuizApplication.Services.Implementations
{
    public abstract class DataService
    {
        protected readonly QuizDbContext context;

        public DataService(QuizDbContext context)
        {
            this.context = context;
        }
    }
}
