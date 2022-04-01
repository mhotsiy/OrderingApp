using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace OrderingApi
{
    public class Order
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public Guid Id { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public decimal? TotalPrice { get; set; }

        [Required] public Starter Starter { get; set; }

        [Required] public MainDish MainDish { get; set; }

        [Required] public Drinks Drinks { get; set; }
    }

    public class MainDish
    {
        [Range(0, 999)] public int Amount { get; set; }
    }

    public class Starter
    {
        [Range(0, 999)] public int Amount { get; set; }
    }

    public class Drinks
    {
        [Range(0, 999)] public int Amount { get; set; }
    }
}