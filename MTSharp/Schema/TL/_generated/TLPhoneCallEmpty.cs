using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x5366c915)]
    public class TLPhoneCallEmpty : TLAbsPhoneCall
    {
        public override uint Constructor
        {
            get
            {
                return 0x5366c915;
            }
        }

        [MTParameter(Order = 0)]
        public long Id { get; set; }


    }
}
