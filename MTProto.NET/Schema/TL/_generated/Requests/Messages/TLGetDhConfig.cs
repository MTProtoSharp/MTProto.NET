using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Messages
{
    [MTObject(0x26cf8950)]
    public class TLGetDhConfig : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x26cf8950;
            }
        }

        [MTParameter(Order = 0)]
        public int Version { get; set; }
        [MTParameter(Order = 1)]
        public int RandomLength { get; set; }


    }
}
