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
    [MTObject(0xe0277a62)]
    public class TLSecureFile : TLAbsSecureFile
    {
        public override uint Constructor
        {
            get
            {
                return 0xe0277a62;
            }
        }

		[MTParameter(Order = 0)]
		public long Id { get; set; }
		[MTParameter(Order = 1)]
		public long AccessHash { get; set; }
		[MTParameter(Order = 2)]
		public int Size { get; set; }
		[MTParameter(Order = 3)]
		public int DcId { get; set; }
		[MTParameter(Order = 4)]
		public int Date { get; set; }
		[MTParameter(Order = 5)]
		public byte[] FileHash { get; set; }
		[MTParameter(Order = 6)]
		public byte[] Secret { get; set; }


    }
}
