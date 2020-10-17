using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Account
{
    [MTObject(0x9cd4eaf9)]
    public class TLGetPasswordSettings : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x9cd4eaf9;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputCheckPasswordSRP Password { get; set; }


    }
}
