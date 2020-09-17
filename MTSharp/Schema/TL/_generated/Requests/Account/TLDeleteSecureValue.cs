using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Account
{
    [MTObject(0xb880bc4b)]
    public class TLDeleteSecureValue : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xb880bc4b;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<TLAbsSecureValueType> Types { get; set; }


    }
}
