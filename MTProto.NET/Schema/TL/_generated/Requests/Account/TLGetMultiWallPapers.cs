using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Account
{
    [MTObject(0x65ad71dc)]
    public class TLGetMultiWallPapers : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x65ad71dc;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<TLAbsInputWallPaper> Wallpapers { get; set; }


    }
}
