using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Account
{
    [MTObject(0xfeed5769)]
    public class TLInstallWallPaper : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xfeed5769;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputWallPaper Wallpaper { get; set; }
        [MTParameter(Order = 1)]
        public MTProto.NET.Schema.TL.TLWallPaperSettings Settings { get; set; }


    }
}
