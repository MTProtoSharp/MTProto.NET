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

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0x327a30cb)]
    public class TLSaveGif : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x327a30cb;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsInputDocument Id { get; set; }
		[MTParameter(Order = 1)]
		public bool Unsave { get; set; }


    }
}
