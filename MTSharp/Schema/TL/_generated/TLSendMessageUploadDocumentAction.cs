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
    [MTObject(0xaa0cd9e4)]
    public class TLSendMessageUploadDocumentAction : TLAbsSendMessageAction
    {
        public override uint Constructor
        {
            get
            {
                return 0xaa0cd9e4;
            }
        }

		[MTParameter(Order = 0)]
		public int Progress { get; set; }


    }
}
