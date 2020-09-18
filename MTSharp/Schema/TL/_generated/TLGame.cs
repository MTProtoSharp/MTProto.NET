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
    [MTObject(0xbdf9653b)]
    public class TLGame : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xbdf9653b;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1)]
		public long Id { get; set; }
		[MTParameter(Order = 2)]
		public long AccessHash { get; set; }
		[MTParameter(Order = 3)]
		public string ShortName { get; set; }
		[MTParameter(Order = 4)]
		public string Title { get; set; }
		[MTParameter(Order = 5)]
		public string Description { get; set; }
		[MTParameter(Order = 6)]
		public TLAbsPhoto Photo { get; set; }
		[MTParameter(Order = 7, FlagBitId=0, FlagType= FlagType.Null)]
		public TLAbsDocument Document { get; set; }


    }
}
