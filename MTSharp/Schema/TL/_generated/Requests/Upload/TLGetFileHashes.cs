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

namespace MTSharp.Schema.TL.Requests.Upload
{
    [MTObject(0xc7025931)]
    public class TLGetFileHashes : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xc7025931;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsInputFileLocation Location { get; set; }
		[MTParameter(Order = 1)]
		public int Offset { get; set; }


    }
}
