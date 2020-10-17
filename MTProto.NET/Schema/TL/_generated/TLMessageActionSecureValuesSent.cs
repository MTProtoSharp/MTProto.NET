using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xd95c6154)]
    public class TLMessageActionSecureValuesSent : TLAbsMessageAction
    {
        public override uint Constructor
        {
            get
            {
                return 0xd95c6154;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<TLAbsSecureValueType> Types { get; set; }


    }
}
