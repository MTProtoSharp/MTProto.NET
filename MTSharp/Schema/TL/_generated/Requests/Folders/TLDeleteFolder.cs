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

namespace MTSharp.Schema.TL.Requests.Folders
{
    [MTObject(0x1c295881)]
    public class TLDeleteFolder : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x1c295881;
            }
        }

		[MTParameter(Order = 0)]
		public int FolderId { get; set; }


    }
}
