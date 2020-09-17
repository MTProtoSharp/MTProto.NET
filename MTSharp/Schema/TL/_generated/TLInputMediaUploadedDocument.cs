using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x5b38c6c1)]
    public class TLInputMediaUploadedDocument : TLAbsInputMedia
    {
        public override uint Constructor
        {
            get
            {
                return 0x5b38c6c1;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 3, FlagType = FlagType.True)]
        public bool NosoundVideo { get; set; }
        [MTParameter(Order = 2)]
        public TLAbsInputFile File { get; set; }
        [MTParameter(Order = 3, FromFlag = 2, FlagType = FlagType.Null)]
        public TLAbsInputFile Thumb { get; set; }
        [MTParameter(Order = 4)]
        public string MimeType { get; set; }
        [MTParameter(Order = 5)]
        public TLVector<TLAbsDocumentAttribute> Attributes { get; set; }
        [MTParameter(Order = 6, FromFlag = 0, FlagType = FlagType.Null)]
        public TLVector<TLAbsInputDocument> Stickers { get; set; }
        [MTParameter(Order = 7, FromFlag = 1, FlagType = FlagType.Null)]
        public int? TtlSeconds { get; set; }


    }
}
