using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Account
{
    [MTObject(0x2442485e)]
    public class TLSetAccountTTL : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x2442485e;
            }
        }

        [MTParameter(Order = 0)]
        public MTProto.NET.Schema.TL.TLAccountDaysTTL Ttl { get; set; }


    }
}
