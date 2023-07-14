using DatatableDemo.Core.Entities;

namespace DatatableDemo.Entities.Concrete
{
    public class Phone : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Message { get; set; }
        public string PhoneNumber { get; set; }
    }
}
