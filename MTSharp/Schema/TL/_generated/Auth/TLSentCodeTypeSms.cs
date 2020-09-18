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
    [MTObject(0xc000bba2)]
    public class TLSentCodeTypeSms : TLAbsSentCodeType
    {
        public override uint Constructor
        {
            get
            {
                return 0xc000bba2;
            }
        }

		[MTParameter(Order = 0)]
		public int Length { get; set; }


    }
}
