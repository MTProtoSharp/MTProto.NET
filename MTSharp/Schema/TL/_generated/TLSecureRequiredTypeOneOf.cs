using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x27477b4)]
    public class TLSecureRequiredTypeOneOf : TLAbsSecureRequiredType
    {
        public override uint Constructor
        {
            get
            {
                return 0x27477b4;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<TLAbsSecureRequiredType> Types { get; set; }


    }
}
