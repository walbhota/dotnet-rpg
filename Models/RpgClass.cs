using System.Text.Json.Serialization;

namespace dotnet_rpg.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight = 1,
        Mage = 2,
        Cleric = 3,
        Thief = 4,
        Paladin = 5,
        Blacksmith = 6,
        Villian = 7,
        Hero = 8
    }
}