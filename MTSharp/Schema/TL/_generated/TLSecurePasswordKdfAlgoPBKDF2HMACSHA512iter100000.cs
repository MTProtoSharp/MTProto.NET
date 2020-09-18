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
    [MTObject(0xbbf2dda0)]
    public class TLSecurePasswordKdfAlgoPBKDF2HMACSHA512iter100000 : TLAbsSecurePasswordKdfAlgo
    {
        public override uint Constructor
        {
            get
            {
                return 0xbbf2dda0;
            }
        }

		[MTParameter(Order = 0)]
		public byte[] Salt { get; set; }


    }
}
