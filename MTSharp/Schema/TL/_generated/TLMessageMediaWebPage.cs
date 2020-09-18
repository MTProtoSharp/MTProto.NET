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
    [MTObject(0xa32dd600)]
    public class TLMessageMediaWebPage : TLAbsMessageMedia
    {
        public override uint Constructor
        {
            get
            {
                return 0xa32dd600;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsWebPage Webpage { get; set; }


    }
}
