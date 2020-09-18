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

namespace MTSharp.Schema.TL.Upload
{
    [MTObject(0xa99fca4f)]
    public class TLCdnFile : TLAbsCdnFile
    {
        public override uint Constructor
        {
            get
            {
                return 0xa99fca4f;
            }
        }

		[MTParameter(Order = 0)]
		public byte[] Bytes { get; set; }


    }
}
