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
    [MTObject(0x438865b)]
    public class TLInputStickeredMediaDocument : TLAbsInputStickeredMedia
    {
        public override uint Constructor
        {
            get
            {
                return 0x438865b;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsInputDocument Id { get; set; }


    }
}
