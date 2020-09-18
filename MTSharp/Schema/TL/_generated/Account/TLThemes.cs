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

namespace MTSharp.Schema.TL.Account
{
    [MTObject(0x7f676421)]
    public class TLThemes : TLAbsThemes
    {
        public override uint Constructor
        {
            get
            {
                return 0x7f676421;
            }
        }

		[MTParameter(Order = 0)]
		public int Hash { get; set; }
		[MTParameter(Order = 1)]
		public TLVector<MTSharp.Schema.TL.TLTheme> Themes { get; set; }


    }
}
