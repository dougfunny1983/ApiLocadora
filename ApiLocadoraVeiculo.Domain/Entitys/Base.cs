using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ApiLocadoraVeiculo.Domain.Entitys
{
    public class Base
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int Id { get; set; }
    }
}