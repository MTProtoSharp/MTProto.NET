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
    [MTObject(0xeea8e46e)]
    public class TLCdnFileReuploadNeeded : TLAbsCdnFile
    {
        public override uint Constructor
        {
            get
            {
                return 0xeea8e46e;
            }
        }

		[MTParameter(Order = 0)]
		public byte[] RequestToken { get; set; }


    }
}
