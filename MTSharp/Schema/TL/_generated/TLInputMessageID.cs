using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xa676a322)]
    public class TLInputMessageID : TLAbsInputMessage
    {
        public override uint Constructor
        {
            get
            {
                return 0xa676a322;
            }
        }

        [MTParameter(Order = 0)]
        public int Id { get; set; }


    }
}
