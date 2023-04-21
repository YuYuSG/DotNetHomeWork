using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OrderApp {
  public class Goods {
    [Key]
    public string ID { get; set; }
    [Required]
    public string Name { get; set; }
    public double Price { get; set; }

    public Goods() {
      ID = Guid.NewGuid().ToString();
    }

    public Goods(string name, double price) {
      Name = name;
      Price = price;
    }

    public override bool Equals(object obj) {
      var goods = obj as Goods;
      return goods != null &&
             ID == goods.ID &&
             Name == goods.Name;
    }

    public override int GetHashCode() {
      var hashCode = 1479869798;
      hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ID);
      hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
      return hashCode;
    }
  }


}
