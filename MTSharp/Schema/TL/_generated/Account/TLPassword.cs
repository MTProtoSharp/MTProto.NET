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

namespace MTSharp.Schema.TL.Account
{
    [MTObject(0xad2641f8)]
    public class TLPassword : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xad2641f8;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FlagBitId=0, FlagType= FlagType.True)]
		public bool HasRecovery { get; set; }
		[MTParameter(Order = 2, FlagBitId=1, FlagType= FlagType.True)]
		public bool HasSecureValues { get; set; }
		[MTParameter(Order = 3, FlagBitId=2, FlagType= FlagType.True)]
		public bool HasPassword { get; set; }
		[MTParameter(Order = 4, FlagBitId=2, FlagType= FlagType.Null)]
		public TLAbsPasswordKdfAlgo CurrentAlgo { get; set; }
		[MTParameter(Order = 5, FlagBitId=2, FlagType= FlagType.Null)]
		public byte[] SrpB { get; set; }
		[MTParameter(Order = 6, FlagBitId=2, FlagType= FlagType.Null)]
		public long? SrpId { get; set; }
		[MTParameter(Order = 7, FlagBitId=3, FlagType= FlagType.Null)]
		public string Hint { get; set; }
		[MTParameter(Order = 8, FlagBitId=4, FlagType= FlagType.Null)]
		public string EmailUnconfirmedPattern { get; set; }
		[MTParameter(Order = 9)]
		public TLAbsPasswordKdfAlgo NewAlgo { get; set; }
		[MTParameter(Order = 10)]
		public TLAbsSecurePasswordKdfAlgo NewSecureAlgo { get; set; }
		[MTParameter(Order = 11)]
		public byte[] SecureRandom { get; set; }


    }
}
