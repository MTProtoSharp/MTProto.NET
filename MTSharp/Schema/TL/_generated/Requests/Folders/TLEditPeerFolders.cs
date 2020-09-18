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
    [MTObject(0x6847d0ab)]
    public class TLEditPeerFolders : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x6847d0ab;
            }
        }

		[MTParameter(Order = 0)]
		public TLVector<MTSharp.Schema.TL.TLInputFolderPeer> FolderPeers { get; set; }


    }
}
