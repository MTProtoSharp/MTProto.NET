using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x1cc6e91f)]
    public class TLInputSingleMedia : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x1cc6e91f;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsInputMedia Media { get; set; }
        [MTParameter(Order = 2)]
        public long RandomId { get; set; }
        [MTParameter(Order = 3)]
        public string Message { get; set; }
        [MTParameter(Order = 4, FromFlag = 0, FlagType = FlagType.Null)]
        public TLVector<TLAbsMessageEntity> Entities { get; set; }


    }
}
