using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
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

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 0, FlagType = FlagType.True)]
        public bool NativeNames { get; set; }
        [MTParameter(Order = 2, FromFlag = 1, FlagType = FlagType.True)]
        public bool SelfieRequired { get; set; }
        [MTParameter(Order = 3, FromFlag = 2, FlagType = FlagType.True)]
        public bool TranslationRequired { get; set; }
        [MTParameter(Order = 4)]
        public TLAbsSecureValueType Type { get; set; }


    }
}
