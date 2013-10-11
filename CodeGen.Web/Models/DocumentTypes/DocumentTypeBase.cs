using Umbraco.Core.Models;

namespace CodeGen.Web.Models.DocumentTypes
{
    public class DocumentTypeBase
    {
        public IPublishedContent Content { get; set; }

        public DocumentTypeBase(IPublishedContent content)
        {
            Content = content;
        }
    }
}