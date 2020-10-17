using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Account
{
    [MTObject(0x38df3532)]
    public class TLUpdateDeviceLocked : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x38df3532;
            }
        }

        [MTParameter(Order = 0)]
        public int Period { get; set; }


    }
}
