using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xa1144770)]
    public class TLSecureValueErrorTranslationFile : TLAbsSecureValueError
    {
        public override uint Constructor
        {
            get
            {
                return 0xa1144770;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsSecureValueType Type { get; set; }
        [MTParameter(Order = 1)]
        public byte[] FileHash { get; set; }
        [MTParameter(Order = 2)]
        public string Text { get; set; }


    }
}
