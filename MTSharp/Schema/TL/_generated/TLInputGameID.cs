using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x32c3e77)]
    public class TLInputGameID : TLAbsInputGame
    {
        public override uint Constructor
        {
            get
            {
                return 0x32c3e77;
            }
        }

        [MTParameter(Order = 0)]
        public long Id { get; set; }
        [MTParameter(Order = 1)]
        public long AccessHash { get; set; }


    }
}
