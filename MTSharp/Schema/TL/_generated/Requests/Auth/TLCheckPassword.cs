using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Auth
{
    [MTObject(0xd18b4d16)]
    public class TLCheckPassword : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xd18b4d16;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputCheckPasswordSRP Password { get; set; }


    }
}
