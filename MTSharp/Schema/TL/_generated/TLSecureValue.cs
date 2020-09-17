using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x187fa0ca)]
    public class TLSecureValue : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x187fa0ca;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsSecureValueType Type { get; set; }
        [MTParameter(Order = 2, FromFlag = 0, FlagType = FlagType.Null)]
        public MTSharp.Schema.TL.TLSecureData Data { get; set; }
        [MTParameter(Order = 3, FromFlag = 1, FlagType = FlagType.Null)]
        public TLAbsSecureFile FrontSide { get; set; }
        [MTParameter(Order = 4, FromFlag = 2, FlagType = FlagType.Null)]
        public TLAbsSecureFile ReverseSide { get; set; }
        [MTParameter(Order = 5, FromFlag = 3, FlagType = FlagType.Null)]
        public TLAbsSecureFile Selfie { get; set; }
        [MTParameter(Order = 6, FromFlag = 6, FlagType = FlagType.Null)]
        public TLVector<TLAbsSecureFile> Translation { get; set; }
        [MTParameter(Order = 7, FromFlag = 4, FlagType = FlagType.Null)]
        public TLVector<TLAbsSecureFile> Files { get; set; }
        [MTParameter(Order = 8, FromFlag = 5, FlagType = FlagType.Null)]
        public TLAbsSecurePlainData PlainData { get; set; }
        [MTParameter(Order = 9)]
        public byte[] Hash { get; set; }


    }
}
