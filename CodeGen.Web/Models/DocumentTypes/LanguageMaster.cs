using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Umbraco.Core.Models;

namespace CodeGen.Web.Models.DocumentTypes
{
    [DisplayName("Language Master")]
    [Description("Språkmaster yo")]
    public partial class LanguageMaster : DocumentTypeBase
    {
        public LanguageMaster(IPublishedContent content) : base(content)
        {
        }

        [DisplayName("Page title")]
        [Description("Yep")]
        [Category("")]
        [DataType("0cc0eba1-9960-42c9-bf9b-60e150b429ae")]
        public string PageTitle { get; set; }
    }
}