using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Help
{
    [MTObject(0xee72f79a)]
    public class TLAcceptTermsOfService : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xee72f79a;
            }
        }

        [MTParameter(Order = 0)]
        public MTSharp.Schema.TL.TLDataJSON Id { get; set; }


    }
}
