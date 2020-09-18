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
    [MTObject(0x5b38c6c1)]
    public class TLInputMediaUploadedDocument : TLAbsInputMedia
    {
        public override uint Constructor
        {
            get
            {
                return 0x5b38c6c1;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FlagBitId=3, FlagType= FlagType.True)]
		public bool NosoundVideo { get; set; }
		[MTParameter(Order = 2, FlagBitId=4, FlagType= FlagType.True)]
		public bool ForceFile { get; set; }
		[MTParameter(Order = 3)]
		public TLAbsInputFile File { get; set; }
		[MTParameter(Order = 4, FlagBitId=2, FlagType= FlagType.Null)]
		public TLAbsInputFile Thumb { get; set; }
		[MTParameter(Order = 5)]
		public string MimeType { get; set; }
		[MTParameter(Order = 6)]
		public TLVector<TLAbsDocumentAttribute> Attributes { get; set; }
		[MTParameter(Order = 7, FlagBitId=0, FlagType= FlagType.Null)]
		public TLVector<TLAbsInputDocument> Stickers { get; set; }
		[MTParameter(Order = 8, FlagBitId=1, FlagType= FlagType.Null)]
		public int? TtlSeconds { get; set; }


    }
}
