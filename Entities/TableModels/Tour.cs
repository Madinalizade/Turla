using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.TableModels
{
    public class Tour :BaseEntity , IEntity
    {
        public string TourName {  get; set; } //Turun adı
        public string Description { get; set; } //Təsviri
        public double Price { get; set; } //Qiyməti
        public DateTime StartDate{ get; set; } // Başlama tarixi
        public DateTime EndDate { get; set; } // Bitmə tarixi
        public string PhotoURL { get; set; } // Şəkil URL

        //Foreign key
        public int CategoryId {  get; set; }
        public Category Category { get; set; }

        //Naviqasiya
        public ICollection<TourRegion> TourRegions { get; set; }
    }
}
