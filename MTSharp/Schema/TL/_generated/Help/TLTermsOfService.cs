using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL.Help
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

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 0, FlagType = FlagType.True)]
        public bool Popup { get; set; }
        [MTParameter(Order = 2)]
        public MTSharp.Schema.TL.TLDataJSON Id { get; set; }
        [MTParameter(Order = 3)]
        public string Text { get; set; }
        [MTParameter(Order = 4)]
        public TLVector<TLAbsMessageEntity> Entities { get; set; }
        [MTParameter(Order = 5, FromFlag = 1, FlagType = FlagType.Null)]
        public int? MinAgeConfirm { get; set; }


    }
}
