using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Channels
{
    [MTObject(0xedd49ef0)]
    public class TLToggleSlowMode : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xedd49ef0;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputChannel Channel { get; set; }
        [MTParameter(Order = 1)]
        public int Seconds { get; set; }


    }
}
