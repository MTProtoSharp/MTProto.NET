using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Messages
{
    [MTObject(0x55a5bb66)]
    public class TLReceivedQueue : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x55a5bb66;
            }
        }

        [MTParameter(Order = 0)]
        public int MaxQts { get; set; }


    }
}
