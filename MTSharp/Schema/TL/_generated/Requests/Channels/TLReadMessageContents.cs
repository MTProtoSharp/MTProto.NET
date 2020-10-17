using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Channels
{
    [MTObject(0xeab5dc38)]
    public class TLReadMessageContents : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xeab5dc38;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputChannel Channel { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<int> Id { get; set; }


    }
}
