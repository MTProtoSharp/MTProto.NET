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

namespace MTSharp.Schema.TL.Help
{
    [MTObject(0x1eb3758)]
    public class TLUserInfo : TLAbsUserInfo
    {
        public override uint Constructor
        {
            get
            {
                return 0x1eb3758;
            }
        }

		[MTParameter(Order = 0)]
		public string Message { get; set; }
		[MTParameter(Order = 1)]
		public TLVector<TLAbsMessageEntity> Entities { get; set; }
		[MTParameter(Order = 2)]
		public string Author { get; set; }
		[MTParameter(Order = 3)]
		public int Date { get; set; }


    }
}
