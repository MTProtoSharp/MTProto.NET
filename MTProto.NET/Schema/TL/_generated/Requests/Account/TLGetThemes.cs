using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Account
{
    [MTObject(0x285946f8)]
    public class TLGetThemes : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x285946f8;
            }
        }

        [MTParameter(Order = 0)]
        public string Format { get; set; }
        [MTParameter(Order = 1)]
        public int Hash { get; set; }


    }
}
