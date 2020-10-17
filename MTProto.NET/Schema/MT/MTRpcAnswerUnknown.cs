using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.MT
{
    [MTObject(0x5e2ad36e)]
    public class MTRpcAnswerUnknown : MTAbsRpcDropAnswer
    {
        public override uint Constructor
        {
            get
            {
                return 0x5e2ad36e;
            }
        }



    }
}
