using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Help
{
    [MTObject(0x17c6b5f6)]
    public class TLSupport : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x17c6b5f6;
            }
        }

        [MTParameter(Order = 0)]
        public string PhoneNumber { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsUser User { get; set; }


    }
}
