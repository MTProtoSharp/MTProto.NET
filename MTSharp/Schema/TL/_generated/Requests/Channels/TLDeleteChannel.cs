using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Channels
{
    [MTObject(0xc0111fe3)]
    public class TLDeleteChannel : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xc0111fe3;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputChannel Channel { get; set; }


    }
}
