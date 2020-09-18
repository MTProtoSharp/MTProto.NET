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
    [MTObject(0xfc796b3f)]
    public class TLKeyboardButtonRequestGeoLocation : TLAbsKeyboardButton
    {
        public override uint Constructor
        {
            get
            {
                return 0xfc796b3f;
            }
        }

		[MTParameter(Order = 0)]
		public string Text { get; set; }


    }
}
