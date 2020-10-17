using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Account
{
    [MTObject(0x702b65a9)]
    public class TLWallPapers : TLAbsWallPapers
    {
        public override uint Constructor
        {
            get
            {
                return 0x702b65a9;
            }
        }

        [MTParameter(Order = 0)]
        public int Hash { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<TLAbsWallPaper> Wallpapers { get; set; }


    }
}
