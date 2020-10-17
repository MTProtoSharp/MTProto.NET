using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Account
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
        public MTSharp.Schema.TL.TLAccountDaysTTL Ttl { get; set; }


    }
}
