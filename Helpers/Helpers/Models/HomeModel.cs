using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Helpers.Models
{
    public class HomeModel
    {
        internal HomeModel()
        {

        }

        public string Username { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        public string Password { get; set; }

        public bool IsMale { get; set; }

        public bool IsActive { get; set; }

        public string Comments { get; set; }

        public string Country { get; set; }

        public HttpPostedFile Avatar { get; set; }

        public IEnumerable<string> AvailableCountries
        {
            get
            {
                return new Collection<string> {
                    "Russia",
                    "Belarus",
                    "Ukraine",
                    "France",
                    "Germany",
                    "United States of America",
                    "Ierland"
                };
            }
        }
    }
}