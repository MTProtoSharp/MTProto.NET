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
    [MTObject(0xfa56ce36)]
    public class TLEncryptedChat : TLAbsEncryptedChat
    {
        public override uint Constructor
        {
            get
            {
                return 0xfa56ce36;
            }
        }

		[MTParameter(Order = 0)]
		public int Id { get; set; }
		[MTParameter(Order = 1)]
		public long AccessHash { get; set; }
		[MTParameter(Order = 2)]
		public int Date { get; set; }
		[MTParameter(Order = 3)]
		public int AdminId { get; set; }
		[MTParameter(Order = 4)]
		public int ParticipantId { get; set; }
		[MTParameter(Order = 5)]
		public byte[] GAOrB { get; set; }
		[MTParameter(Order = 6)]
		public long KeyFingerprint { get; set; }


    }
}
