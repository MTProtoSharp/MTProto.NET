using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Account
{
    [MTObject(0x73665bc2)]
    public class TLGetSecureValue : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x73665bc2;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<TLAbsSecureValueType> Types { get; set; }


    }
}
