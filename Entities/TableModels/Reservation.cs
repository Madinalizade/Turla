using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.TableModels
{
    public class Reservation :BaseEntity,IEntity
    {
        public DateTime ReservationDate { get; set; }
        public string Status {  get; set; } // Rezervasiyanın statusu (məsələn, "Təsdiqləndi", "İmtina edildi")

        //Foreign Keys
        public int CustomerId {  get; set; }
        public Customer Customer { get; set; }

        public int TourId {  get; set; }
        public Tour Tour { get; set; }


    }
}
