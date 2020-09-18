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
    [MTObject(0xf141b5e1)]
    public class TLInputEncryptedChat : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xf141b5e1;
            }
        }

		[MTParameter(Order = 0)]
		public int ChatId { get; set; }
		[MTParameter(Order = 1)]
		public long AccessHash { get; set; }


    }
}
