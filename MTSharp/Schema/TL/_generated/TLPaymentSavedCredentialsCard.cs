using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xcdc27a1f)]
    public class TLPaymentSavedCredentialsCard : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xcdc27a1f;
            }
        }

        [MTParameter(Order = 0)]
        public string Id { get; set; }
        [MTParameter(Order = 1)]
        public string Title { get; set; }


    }
}
