using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xd33f43f3)]
    public class TLInputMediaGame : TLAbsInputMedia
    {
        public override uint Constructor
        {
            get
            {
                return 0xd33f43f3;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputGame Id { get; set; }


    }
}
