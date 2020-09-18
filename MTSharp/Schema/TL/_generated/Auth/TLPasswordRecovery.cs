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

namespace MTSharp.Schema.TL.Auth
{
    [MTObject(0x137948a5)]
    public class TLPasswordRecovery : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x137948a5;
            }
        }

		[MTParameter(Order = 0)]
		public string EmailPattern { get; set; }


    }
}
