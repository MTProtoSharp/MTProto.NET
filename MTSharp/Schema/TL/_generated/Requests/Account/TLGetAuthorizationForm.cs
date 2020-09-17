using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Account
{
    [MTObject(0xb86ba8e1)]
    public class TLGetAuthorizationForm : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xb86ba8e1;
            }
        }

        [MTParameter(Order = 0)]
        public int BotId { get; set; }
        [MTParameter(Order = 1)]
        public string Scope { get; set; }
        [MTParameter(Order = 2)]
        public string PublicKey { get; set; }


    }
}
