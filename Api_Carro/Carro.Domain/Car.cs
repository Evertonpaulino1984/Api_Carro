using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro.Domain
{
    [BsonIgnoreExtraElements]
    public class Car
    {
        public Car()
        {           
                Key = Guid.NewGuid().ToString();
                Register = DateTime.Now;
                Update = DateTime.Now;
                IsActive = true;            
        }
    public string Key { get; set; }
    public DateTime Register { get; set; }
    public DateTime Update { get; set; }
    public bool IsActive { get; set; }
    public string Model { get; set; }
    public int YearFabrication { get; set; }
    public string Brand { get; set; }
    public string Color { get; set; }
    public bool Brazilian { get; set; }

    }
}
