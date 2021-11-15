using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    // tüzel müşteri sınıfı
    // inheritance-miras
    class CorporateCustomer:Customer
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
