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

namespace MTSharp.Schema.TL.Help
{
    [MTObject(0xe3309f7f)]
    public class TLTermsOfServiceUpdateEmpty : TLAbsTermsOfServiceUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0xe3309f7f;
            }
        }

		[MTParameter(Order = 0)]
		public int Expires { get; set; }


    }
}
