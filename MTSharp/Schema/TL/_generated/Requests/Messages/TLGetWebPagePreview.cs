using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0x8b68b0cc)]
    public class TLGetWebPagePreview : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x8b68b0cc;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public string Message { get; set; }
        [MTParameter(Order = 2, FlagBitId = 3, FlagType = FlagType.Null)]
        public TLVector<TLAbsMessageEntity> Entities { get; set; }


    }
}
