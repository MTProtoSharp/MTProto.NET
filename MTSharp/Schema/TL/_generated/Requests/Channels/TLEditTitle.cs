using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Channels
{
    [MTObject(0x566decd0)]
    public class TLEditTitle : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x566decd0;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputChannel Channel { get; set; }
        [MTParameter(Order = 1)]
        public string Title { get; set; }


    }
}
