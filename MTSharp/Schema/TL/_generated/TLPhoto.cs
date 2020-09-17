using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0xd07504a5)]
    public class TLPhoto : TLAbsPhoto
    {
        public override uint Constructor
        {
            get
            {
                return 0xd07504a5;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 0, FlagType = FlagType.True)]
        public bool HasStickers { get; set; }
        [MTParameter(Order = 2)]
        public long Id { get; set; }
        [MTParameter(Order = 3)]
        public long AccessHash { get; set; }
        [MTParameter(Order = 4)]
        public byte[] FileReference { get; set; }
        [MTParameter(Order = 5)]
        public int Date { get; set; }
        [MTParameter(Order = 6)]
        public TLVector<TLAbsPhotoSize> Sizes { get; set; }
        [MTParameter(Order = 7)]
        public int DcId { get; set; }


    }
}
