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

namespace MTSharp.Schema.TL.Requests.Auth
{
    [MTObject(0x67a3ff2c)]
    public class TLImportBotAuthorization : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x67a3ff2c;
            }
        }

		[MTParameter(Order = 0)]
		public int Flags { get; set; }
		[MTParameter(Order = 1)]
		public int ApiId { get; set; }
		[MTParameter(Order = 2)]
		public string ApiHash { get; set; }
		[MTParameter(Order = 3)]
		public string BotAuthToken { get; set; }


    }
}
