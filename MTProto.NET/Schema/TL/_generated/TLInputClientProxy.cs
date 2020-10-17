using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x75588b3f)]
    public class TLInputClientProxy : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x75588b3f;
            }
        }

        [MTParameter(Order = 0)]
        public string Address { get; set; }
        [MTParameter(Order = 1)]
        public int Port { get; set; }


    }
}
