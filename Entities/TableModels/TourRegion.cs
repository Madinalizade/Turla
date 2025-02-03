using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.TableModels
{
    public class TourRegion :BaseEntity,IEntity
    {
        public int TourId {  get; set; }
        public Tour Tour { get; set; }
        public int RegionId { get; set; }
        public Region Region { get; set; }
    }
}
