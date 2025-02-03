using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.TableModels
{
    public class Region :BaseEntity,IEntity
    {
        public string RegionName { get; set; } // Bölgənin adı
        public string Description { get; set; } // Ətraflı təsvir

        public ICollection<TourRegion> TourRegions { get; set; }
    }
}
