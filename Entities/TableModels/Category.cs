using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.TableModels
{
    public class Category : BaseEntity,IEntity
    {
        public string CategoryName { get; set; } // Kateqoriya adı
        public string Description { get; set; } // Ətraflı təsvir

        //naviqasiya
        public ICollection<Tour> Tours { get; set; }
    }
}
