using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Account
{
    [MTObject(0x1c199183)]
    public class TLWallPapersNotModified : TLAbsWallPapers
    {
        public override uint Constructor
        {
            get
            {
                return 0x1c199183;
            }
        }



    }
}
