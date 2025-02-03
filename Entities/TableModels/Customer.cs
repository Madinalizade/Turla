using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.TableModels
{
    public class Customer :BaseEntity,IEntity
    {
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string PhoneNumber { get; set; }
        public string Email {  get; set; }
        public string Password {  get; set; }

       //naviqasiya
       public ICollection<Reservation> Reservations { get; set; }

    }
}
