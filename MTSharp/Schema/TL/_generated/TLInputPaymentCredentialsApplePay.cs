using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MTSharp;
using MTSharp.Attributes;
using MTSharp.Enums;
using MTSharp.Schema;
using MTSharp.Schema.TL;

namespace MTSharp.Schema.TL
{
    [MTObject(0xaa1c39f)]
    public class TLInputPaymentCredentialsApplePay : TLAbsInputPaymentCredentials
    {
        public override uint Constructor
        {
            get
            {
                return 0xaa1c39f;
            }
        }

		[MTParameter(Order = 0)]
		public MTSharp.Schema.TL.TLDataJSON PaymentData { get; set; }


    }
}
