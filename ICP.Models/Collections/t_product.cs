using ICP.Models.DBSettings.Concrete;
using ICP.Models.DBSettings.Helpers.DBCollectionHelper;
using System.Collections.Generic;

namespace ICP.Models.Collections
{
    [BsonCollection("t_product")]
    public class t_product : Document
    {
        public string name { get; set; }
        public string description { get; set; }
        public ICollection<t_image> images{ get; set; }
    }
}
