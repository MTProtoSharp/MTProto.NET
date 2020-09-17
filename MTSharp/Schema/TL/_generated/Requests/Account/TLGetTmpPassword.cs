using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Account
{
    [MTObject(0x449e0b51)]
    public class TLGetTmpPassword : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x449e0b51;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputCheckPasswordSRP Password { get; set; }
        [MTParameter(Order = 1)]
        public int Period { get; set; }


    }
}
