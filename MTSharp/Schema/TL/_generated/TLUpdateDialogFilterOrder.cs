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
    [MTObject(0xa5d72105)]
    public class TLUpdateDialogFilterOrder : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0xa5d72105;
            }
        }

		[MTParameter(Order = 0)]
		public TLVector<int> Order { get; set; }


    }
}
