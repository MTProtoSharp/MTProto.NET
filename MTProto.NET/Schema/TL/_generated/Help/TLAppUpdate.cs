using MTProto.NET.Attributes;
using MTProto.NET.Enums;

namespace MTProto.NET.Schema.TL.Help
{
    [MTObject(0x1da7158f)]
    public class TLAppUpdate : TLAbsAppUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x1da7158f;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool CanNotSkip { get; set; }
        [MTParameter(Order = 2)]
        public int Id { get; set; }
        [MTParameter(Order = 3)]
        public string Version { get; set; }
        [MTParameter(Order = 4)]
        public string Text { get; set; }
        [MTParameter(Order = 5)]
        public TLVector<TLAbsMessageEntity> Entities { get; set; }
        [MTParameter(Order = 6, FlagBitId = 1, FlagType = FlagType.Null)]
        public TLAbsDocument Document { get; set; }
        [MTParameter(Order = 7, FlagBitId = 2, FlagType = FlagType.Null)]
        public string Url { get; set; }


    }
}
