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

namespace MTSharp.Schema.TL.Upload
{
    [MTObject(0x21e753bc)]
    public class TLWebFile : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x21e753bc;
            }
        }

		[MTParameter(Order = 0)]
		public int Size { get; set; }
		[MTParameter(Order = 1)]
		public string MimeType { get; set; }
		[MTParameter(Order = 2)]
		public Storage.TLAbsFileType FileType { get; set; }
		[MTParameter(Order = 3)]
		public int Mtime { get; set; }
		[MTParameter(Order = 4)]
		public byte[] Bytes { get; set; }


    }
}
