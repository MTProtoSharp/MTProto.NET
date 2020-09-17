using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xecd75d8c)]
    public class TLUserProfilePhoto : TLAbsUserProfilePhoto
    {
        public override uint Constructor
        {
            get
            {
                return 0xecd75d8c;
            }
        }

        [MTParameter(Order = 0)]
        public long PhotoId { get; set; }
        [MTParameter(Order = 1)]
        public MTSharp.Schema.TL.TLFileLocationToBeDeprecated PhotoSmall { get; set; }
        [MTParameter(Order = 2)]
        public MTSharp.Schema.TL.TLFileLocationToBeDeprecated PhotoBig { get; set; }
        [MTParameter(Order = 3)]
        public int DcId { get; set; }


    }
}
