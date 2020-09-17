using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Account
{
    [MTObject(0x6c5a5b37)]
    public class TLSaveWallPaper : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x6c5a5b37;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputWallPaper Wallpaper { get; set; }
        [MTParameter(Order = 1)]
        public bool Unsave { get; set; }
        [MTParameter(Order = 2)]
        public MTSharp.Schema.TL.TLWallPaperSettings Settings { get; set; }


    }
}
