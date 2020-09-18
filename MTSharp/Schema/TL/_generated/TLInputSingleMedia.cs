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
    [MTObject(0x1cc6e91f)]
    public class TLInputSingleMedia : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x1cc6e91f;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1)]
		public TLAbsInputMedia Media { get; set; }
		[MTParameter(Order = 2)]
		public long RandomId { get; set; }
		[MTParameter(Order = 3)]
		public string Message { get; set; }
		[MTParameter(Order = 4, FlagBitId=0, FlagType= FlagType.Null)]
		public TLVector<TLAbsMessageEntity> Entities { get; set; }


    }
}
