using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Auth
{
    [MTObject(0x8e48a188)]
    public class TLDropTempAuthKeys : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x8e48a188;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<long> ExceptAuthKeys { get; set; }


    }
}
