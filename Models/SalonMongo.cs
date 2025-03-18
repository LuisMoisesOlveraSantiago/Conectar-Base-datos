using MongoDB.Bson.Serialization.Attributes;

public class SalonMongo {
    [BsonId]
    [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]

    public string? Id { get; set; }
    public string Edificio { get; set; } = string.Empty
    public string Nombre { get; set; } = string.Empty
    public string Uso { get; set; } = string.Empty
    public decimal largo { get; set; }
    public string Ancho { get; set; }
    public int capacidad  { get; set; } 
    public list<string>? Grupos  { get; set; }
}