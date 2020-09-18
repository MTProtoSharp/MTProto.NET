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
    [MTObject(0xf5235d55)]
    public class TLInputEncryptedFileLocation : TLAbsInputFileLocation
    {
        public override uint Constructor
        {
            get
            {
                return 0xf5235d55;
            }
        }

		[MTParameter(Order = 0)]
		public long Id { get; set; }
		[MTParameter(Order = 1)]
		public long AccessHash { get; set; }


    }
}
