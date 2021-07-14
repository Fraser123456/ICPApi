using MongoDB.Bson.Serialization.Attributes;
using System;

namespace ICP.Models.DBSettings.Abstract
{
    public interface IDocument
    {
        [BsonId]
        int _id { get; set; }
        bool is_deleted { get; set; }
        int create_user { get; set; }
        int update_user { get; set; }
        DateTime update_date { get; set; }
        DateTime create_date { get; set; }
    }
}
