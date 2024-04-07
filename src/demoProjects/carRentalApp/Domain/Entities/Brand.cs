using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Brand : Entity
    {
        public string Name { get; set; }
        public virtual ICollection<Model> Models { get; set; } //Farklı bir ORM kullanılması gereken bir durumda sıkıntı olmaması için virtual keywoed ü kullanılıyor.
                                                               //Örn:NHibernate ORM inde bu keywor ün kullanılması gerekiyor.

        public Brand()
        {
        }

        public Brand(int id, string name) : this() // Parametreli kurucu çalışırken parametresiz kurucunun da çalışması için this() kullanıldı.
        {
            Id = id;
            Name = name;
        }
    }
}
