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
    [MTObject(0x92a72876)]
    public class TLMessageActionGameScore : TLAbsMessageAction
    {
        public override uint Constructor
        {
            get
            {
                return 0x92a72876;
            }
        }

		[MTParameter(Order = 0)]
		public long GameId { get; set; }
		[MTParameter(Order = 1)]
		public int Score { get; set; }


    }
}
