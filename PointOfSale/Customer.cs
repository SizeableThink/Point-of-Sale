using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace PointOfSale
{
    public class Customer
    {
        private string CustomerID;
        //member is true, non-member is false
        private bool MemberStatus;
        //tax exempt is true, not tax exempt is false
        private bool TaxStatus;

        public Customer(string id, bool member, bool tax)
        {
            CustomerID = id;
            MemberStatus = member;
            TaxStatus = tax;
        }

        public bool GetMemberStatus()
        {
            return this.MemberStatus;
        }

        public bool GetTaxStatus()
        {
            return this.TaxStatus;
        }
    }
}
