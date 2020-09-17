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

namespace MTSharp.Schema.TL.Requests.Users
{
    [MTObject(0xca30a5b1)]
    public class TLGetFullUser : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xca30a5b1;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsInputUser Id { get; set; }


    }
}
