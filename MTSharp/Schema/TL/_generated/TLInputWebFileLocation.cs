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
    [MTObject(0xc239d686)]
    public class TLInputWebFileLocation : TLAbsInputWebFileLocation
    {
        public override uint Constructor
        {
            get
            {
                return 0xc239d686;
            }
        }

		[MTParameter(Order = 0)]
		public string Url { get; set; }
		[MTParameter(Order = 1)]
		public long AccessHash { get; set; }


    }
}
