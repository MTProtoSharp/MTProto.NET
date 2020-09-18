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

namespace MTSharp.Schema.TL.Requests.Account
{
    [MTObject(0x8432c21f)]
    public class TLCreateTheme : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x8432c21f;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1)]
		public string Slug { get; set; }
		[MTParameter(Order = 2)]
		public string Title { get; set; }
		[MTParameter(Order = 3, FlagBitId=2, FlagType= FlagType.Null)]
		public TLAbsInputDocument Document { get; set; }
		[MTParameter(Order = 4, FlagBitId=3, FlagType= FlagType.Null)]
		public MTSharp.Schema.TL.TLInputThemeSettings Settings { get; set; }


    }
}
