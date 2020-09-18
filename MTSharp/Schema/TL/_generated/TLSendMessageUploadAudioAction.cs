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
    [MTObject(0xf351d7ab)]
    public class TLSendMessageUploadAudioAction : TLAbsSendMessageAction
    {
        public override uint Constructor
        {
            get
            {
                return 0xf351d7ab;
            }
        }

		[MTParameter(Order = 0)]
		public int Progress { get; set; }


    }
}
