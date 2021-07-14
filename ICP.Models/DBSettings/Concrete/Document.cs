using MongoDB.Bson.Serialization.Attributes;
using ICP.Models.DBSettings.Abstract;
using System;

namespace ICP.Models.DBSettings.Concrete
{
    public class Document : IDocument
    {
        [BsonId]
        public int _id { get; set; }
        public bool is_deleted { get; set; }
        public int create_user { get; set; }
        public int update_user { get; set; }
        public DateTime update_date { get; set; }
        public DateTime create_date { get; set; }
    }
}
