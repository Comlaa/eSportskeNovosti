namespace ESN_Api.ESN_Api.dal.ViewModels
{
    public class ArticleCommentsVM
    {
        public string Name { get; set; }
        public string Comment { get; set; }

        public ArticleCommentsVM()
        {

        }

        public ArticleCommentsVM(string name, string comment)
        {
            Name = name;
            Comment = comment;
        }
    }
}
