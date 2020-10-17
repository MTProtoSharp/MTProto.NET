using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests
{
    [MTObject(0xda9b0d0d)]
    public class TLInvokeWithLayer : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xda9b0d0d;
            }
        }

        [MTParameter(Order = 0)]
        public int Layer { get; set; }
        [MTParameter(Order = 1)]
        public MTObject Query { get; set; }


    }
}
