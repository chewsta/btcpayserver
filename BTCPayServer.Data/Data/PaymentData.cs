using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTCPayServer.Data
{
    public class PaymentData
    {
        public string Id
        {
            get; set;
        }

        public string InvoiceDataId
        {
            get; set;
        }
        public InvoiceData InvoiceData
        {
            get; set;
        }

        public byte[] Blob
        {
            get; set;
        }
        public bool Accounted
        {
            get; set;
        }
    }
}
