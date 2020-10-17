using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Auth
{
    [MTObject(0xd897bc66)]
    public class TLRequestPasswordRecovery : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xd897bc66;
            }
        }



    }
}
