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

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0x9cb126e)]
    public class TLCreateChat : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x9cb126e;
            }
        }

		[MTParameter(Order = 0)]
		public TLVector<TLAbsInputUser> Users { get; set; }
		[MTParameter(Order = 1)]
		public string Title { get; set; }


    }
}