using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Account
{
    [MTObject(0xdb64fd34)]
    public class TLTmpPassword : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xdb64fd34;
            }
        }

        [MTParameter(Order = 0)]
        public byte[] TmpPassword { get; set; }
        [MTParameter(Order = 1)]
        public int ValidUntil { get; set; }


    }
}
