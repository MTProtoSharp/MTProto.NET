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
    [MTObject(0x56022f4d)]
    public class TLUpdateLangPack : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x56022f4d;
            }
        }

		[MTParameter(Order = 0)]
		public MTSharp.Schema.TL.TLLangPackDifference Difference { get; set; }


    }
}
