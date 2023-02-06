using System.Text.Json.Serialization;

namespace Net.Models
{
    public enum RPGClass
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]
        Knight = 1,
        Mage = 2,
        Cleric = 3,
        Archer = 4
    }
}