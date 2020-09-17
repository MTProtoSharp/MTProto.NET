using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x9ba2d800)]
    public class TLChatEmpty : TLAbsChat
    {
        public override uint Constructor
        {
            get
            {
                return 0x9ba2d800;
            }
        }

        [MTParameter(Order = 0)]
        public int Id { get; set; }


    }
}
