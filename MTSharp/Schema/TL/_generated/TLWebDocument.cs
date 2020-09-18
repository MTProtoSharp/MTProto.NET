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
    [MTObject(0x1c570ed1)]
    public class TLWebDocument : TLAbsWebDocument
    {
        public override uint Constructor
        {
            get
            {
                return 0x1c570ed1;
            }
        }

		[MTParameter(Order = 0)]
		public string Url { get; set; }
		[MTParameter(Order = 1)]
		public long AccessHash { get; set; }
		[MTParameter(Order = 2)]
		public int Size { get; set; }
		[MTParameter(Order = 3)]
		public string MimeType { get; set; }
		[MTParameter(Order = 4)]
		public TLVector<TLAbsDocumentAttribute> Attributes { get; set; }


    }
}
