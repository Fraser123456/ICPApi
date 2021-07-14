using ICP.Models.DBSettings.Concrete;
using ICP.Models.DBSettings.Helpers.DBCollectionHelper;

namespace ICP.Models.Collections
{
    [BsonCollection("t_category")]
    public class t_category : Document
    {
        public string name { get; set; }
    }
}
