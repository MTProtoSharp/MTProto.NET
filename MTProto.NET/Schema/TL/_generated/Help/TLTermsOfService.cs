using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL.Help
{
    [MTObject(0x780a0310)]
    public class TLTermsOfService : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x780a0310;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool Popup { get; set; }
        [MTParameter(Order = 2)]
        public MTProto.NET.Schema.TL.TLDataJSON Id { get; set; }
        [MTParameter(Order = 3)]
        public string Text { get; set; }
        [MTParameter(Order = 4)]
        public TLVector<TLAbsMessageEntity> Entities { get; set; }
        [MTParameter(Order = 5, FlagBitId = 1, FlagType = FlagType.Null)]
        public int? MinAgeConfirm { get; set; }


    }
}
