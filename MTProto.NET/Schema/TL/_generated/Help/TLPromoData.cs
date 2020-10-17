using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL.Help
{
    [MTObject(0x8c39793f)]
    public class TLPromoData : TLAbsPromoData
    {
        public override uint Constructor
        {
            get
            {
                return 0x8c39793f;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool Proxy { get; set; }
        [MTParameter(Order = 2)]
        public int Expires { get; set; }
        [MTParameter(Order = 3)]
        public TLAbsPeer Peer { get; set; }
        [MTParameter(Order = 4)]
        public TLVector<TLAbsChat> Chats { get; set; }
        [MTParameter(Order = 5)]
        public TLVector<TLAbsUser> Users { get; set; }
        [MTParameter(Order = 6, FlagBitId = 1, FlagType = FlagType.Null)]
        public string PsaType { get; set; }
        [MTParameter(Order = 7, FlagBitId = 2, FlagType = FlagType.Null)]
        public string PsaMessage { get; set; }


    }
}
