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
    [MTObject(0xa098d6af)]
    public class TLPassportConfig : TLAbsPassportConfig
    {
        public override uint Constructor
        {
            get
            {
                return 0xa098d6af;
            }
        }

		[MTParameter(Order = 0)]
		public int Hash { get; set; }
		[MTParameter(Order = 1)]
		public MTSharp.Schema.TL.TLDataJSON CountriesLangs { get; set; }


    }
}
