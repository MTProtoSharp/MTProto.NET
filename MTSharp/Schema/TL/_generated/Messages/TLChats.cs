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

namespace MTSharp.Schema.TL.Messages
{
    [MTObject(0x64ff9fd5)]
    public class TLChats : TLAbsChats
    {
        public override uint Constructor
        {
            get
            {
                return 0x64ff9fd5;
            }
        }

		[MTParameter(Order = 0)]
		public TLVector<TLAbsChat> Chats { get; set; }


    }
}
