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

namespace MTSharp.Schema.TL.Requests.Account
{
    [MTObject(0x73665bc2)]
    public class TLGetSecureValue : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x73665bc2;
            }
        }

		[MTParameter(Order = 0)]
		public TLVector<TLAbsSecureValueType> Types { get; set; }


    }
}
