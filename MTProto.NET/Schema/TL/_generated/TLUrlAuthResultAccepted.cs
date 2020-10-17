using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x8f8c0e4e)]
    public class TLUrlAuthResultAccepted : TLAbsUrlAuthResult
    {
        public override uint Constructor
        {
            get
            {
                return 0x8f8c0e4e;
            }
        }

        [MTParameter(Order = 0)]
        public string Url { get; set; }


    }
}
