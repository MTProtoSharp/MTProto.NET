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
    [MTObject(0x2e0709a5)]
    public class TLSavedGifs : TLAbsSavedGifs
    {
        public override uint Constructor
        {
            get
            {
                return 0x2e0709a5;
            }
        }

		[MTParameter(Order = 0)]
		public int Hash { get; set; }
		[MTParameter(Order = 1)]
		public TLVector<TLAbsDocument> Gifs { get; set; }


    }
}
