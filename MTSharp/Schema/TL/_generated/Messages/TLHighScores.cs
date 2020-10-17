using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Messages
{
    [MTObject(0x9a3bfd99)]
    public class TLHighScores : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x9a3bfd99;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<MTSharp.Schema.TL.TLHighScore> Scores { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<TLAbsUser> Users { get; set; }


    }
}
