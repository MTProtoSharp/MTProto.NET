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

namespace MTSharp.Schema.TL.Messages
{
    [MTObject(0xe4599bbd)]
    public class TLStickers : TLAbsStickers
    {
        public override uint Constructor
        {
            get
            {
                return 0xe4599bbd;
            }
        }

		[MTParameter(Order = 0)]
		public int Hash { get; set; }
		[MTParameter(Order = 1)]
		public TLVector<TLAbsDocument> Stickers { get; set; }


    }
}
