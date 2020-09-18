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
    [MTObject(0xab7ec0a0)]
    public class TLEncryptedChatEmpty : TLAbsEncryptedChat
    {
        public override uint Constructor
        {
            get
            {
                return 0xab7ec0a0;
            }
        }

		[MTParameter(Order = 0)]
		public int Id { get; set; }


    }
}
