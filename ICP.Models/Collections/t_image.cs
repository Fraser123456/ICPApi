using ICP.Models.DBSettings.Concrete;
using ICP.Models.DBSettings.Helpers.DBCollectionHelper;

namespace ICP.Models.Collections
{
    [BsonCollection("t_image")]
    public class t_image : Document
    {
        public int t_product_id { get; set; }
        public string url { get; set; }
        public string public_id { get; set; }
    }
}
