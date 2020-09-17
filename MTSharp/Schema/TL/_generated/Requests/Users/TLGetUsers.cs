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
    [MTObject(0xd91a548)]
    public class TLGetUsers : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xd91a548;
            }
        }

		[MTParameter(Order = 0)]
		public TLVector<TLAbsInputUser> Id { get; set; }


    }
}
