using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Account
{
    [MTObject(0xfc8ddbea)]
    public class TLGetWallPaper : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xfc8ddbea;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputWallPaper Wallpaper { get; set; }


    }
}
