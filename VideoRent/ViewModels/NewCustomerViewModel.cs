using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VideoRent.Models;

namespace VideoRent.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes;
        public Customer Customer { get; set; }
    }
}