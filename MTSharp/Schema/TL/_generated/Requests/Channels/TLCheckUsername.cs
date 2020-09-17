using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Channels
{
    [MTObject(0x10e6bd2c)]
    public class TLCheckUsername : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x10e6bd2c;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputChannel Channel { get; set; }
        [MTParameter(Order = 1)]
        public string Username { get; set; }


    }
}
