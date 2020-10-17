using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xc642724e)]
    public class TLInputChatUploadedPhoto : TLAbsInputChatPhoto
    {
        public override uint Constructor
        {
            get
            {
                return 0xc642724e;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.Null)]
        public TLAbsInputFile File { get; set; }
        [MTParameter(Order = 2, FlagBitId = 1, FlagType = FlagType.Null)]
        public TLAbsInputFile Video { get; set; }
        [MTParameter(Order = 3, FlagBitId = 2, FlagType = FlagType.Null)]
        public double? VideoStartTs { get; set; }


    }
}
