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

namespace MTSharp.Schema.TL.Payments
{
    [MTObject(0x3f56aea3)]
    public class TLPaymentForm : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x3f56aea3;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FlagBitId=2, FlagType= FlagType.True)]
		public bool CanSaveCredentials { get; set; }
		[MTParameter(Order = 2, FlagBitId=3, FlagType= FlagType.True)]
		public bool PasswordMissing { get; set; }
		[MTParameter(Order = 3)]
		public int BotId { get; set; }
		[MTParameter(Order = 4)]
		public MTSharp.Schema.TL.TLInvoice Invoice { get; set; }
		[MTParameter(Order = 5)]
		public int ProviderId { get; set; }
		[MTParameter(Order = 6)]
		public string Url { get; set; }
		[MTParameter(Order = 7, FlagBitId=4, FlagType= FlagType.Null)]
		public string NativeProvider { get; set; }
		[MTParameter(Order = 8, FlagBitId=4, FlagType= FlagType.Null)]
		public MTSharp.Schema.TL.TLDataJSON NativeParams { get; set; }
		[MTParameter(Order = 9, FlagBitId=0, FlagType= FlagType.Null)]
		public MTSharp.Schema.TL.TLPaymentRequestedInfo SavedInfo { get; set; }
		[MTParameter(Order = 10, FlagBitId=1, FlagType= FlagType.Null)]
		public MTSharp.Schema.TL.TLPaymentSavedCredentialsCard SavedCredentials { get; set; }
		[MTParameter(Order = 11)]
		public TLVector<TLAbsUser> Users { get; set; }


    }
}
