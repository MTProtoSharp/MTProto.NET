using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xbad88395)]
    public class TLInputMessageReplyTo : TLAbsInputMessage
    {
        public override uint Constructor
        {
            get
            {
                return 0xbad88395;
            }
        }

        [MTParameter(Order = 0)]
        public int Id { get; set; }


    }
}
