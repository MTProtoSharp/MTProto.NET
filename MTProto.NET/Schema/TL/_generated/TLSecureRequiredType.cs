using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x829d99da)]
    public class TLSecureRequiredType : TLAbsSecureRequiredType
    {
        public override uint Constructor
        {
            get
            {
                return 0x829d99da;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool NativeNames { get; set; }
        [MTParameter(Order = 2, FlagBitId = 1, FlagType = FlagType.True)]
        public bool SelfieRequired { get; set; }
        [MTParameter(Order = 3, FlagBitId = 2, FlagType = FlagType.True)]
        public bool TranslationRequired { get; set; }
        [MTParameter(Order = 4)]
        public TLAbsSecureValueType Type { get; set; }


    }
}
