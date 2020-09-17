using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x475cdbd5)]
    public class TLChatPhoto : TLAbsChatPhoto
    {
        public override uint Constructor
        {
            get
            {
                return 0x475cdbd5;
            }
        }

        [MTParameter(Order = 0)]
        public MTSharp.Schema.TL.TLFileLocationToBeDeprecated PhotoSmall { get; set; }
        [MTParameter(Order = 1)]
        public MTSharp.Schema.TL.TLFileLocationToBeDeprecated PhotoBig { get; set; }
        [MTParameter(Order = 2)]
        public int DcId { get; set; }


    }
}
