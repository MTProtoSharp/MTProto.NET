using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Account
{
    [MTObject(0x2714d86c)]
    public class TLCheckUsername : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x2714d86c;
            }
        }

        [MTParameter(Order = 0)]
        public string Username { get; set; }


    }
}
