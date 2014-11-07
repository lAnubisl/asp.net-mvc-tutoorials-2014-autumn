using System.Collections.Generic;
using System.Web;
namespace Forms.Models
{
    public class UserModel
    {
        public ICollection<string> Countries
        {
            get
            {
                return Repository.CountriesRepository.Countries;
            }
        }

        public HttpPostedFileWrapper Avatar { get; set; }

        public string Country { get; set; }

        public int Age { get; set; }

        public string Username { get; set; }
    }
}