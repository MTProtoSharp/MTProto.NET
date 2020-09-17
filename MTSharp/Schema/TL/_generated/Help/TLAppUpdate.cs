using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL.Help
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

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 0, FlagType = FlagType.True)]
        public bool CanNotSkip { get; set; }
        [MTParameter(Order = 2)]
        public int Id { get; set; }
        [MTParameter(Order = 3)]
        public string Version { get; set; }
        [MTParameter(Order = 4)]
        public string Text { get; set; }
        [MTParameter(Order = 5)]
        public TLVector<TLAbsMessageEntity> Entities { get; set; }
        [MTParameter(Order = 6, FromFlag = 1, FlagType = FlagType.Null)]
        public TLAbsDocument Document { get; set; }
        [MTParameter(Order = 7, FromFlag = 2, FlagType = FlagType.Null)]
        public string Url { get; set; }


    }
}
