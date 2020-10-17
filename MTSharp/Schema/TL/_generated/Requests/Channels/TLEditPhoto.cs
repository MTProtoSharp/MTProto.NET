using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Channels
{
    [MTObject(0xf12e57c9)]
    public class TLEditPhoto : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xf12e57c9;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputChannel Channel { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsInputChatPhoto Photo { get; set; }


    }
}
