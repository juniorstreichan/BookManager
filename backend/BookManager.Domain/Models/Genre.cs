using System.Runtime.Serialization;
using System;
namespace BookManager.Domain.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}