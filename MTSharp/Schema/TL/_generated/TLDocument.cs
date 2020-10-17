using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x1e87342b)]
    public class TLDocument : TLAbsDocument
    {
        public override uint Constructor
        {
            get
            {
                return 0x1e87342b;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public long Id { get; set; }
        [MTParameter(Order = 2)]
        public long AccessHash { get; set; }
        [MTParameter(Order = 3)]
        public byte[] FileReference { get; set; }
        [MTParameter(Order = 4)]
        public int Date { get; set; }
        [MTParameter(Order = 5)]
        public string MimeType { get; set; }
        [MTParameter(Order = 6)]
        public int Size { get; set; }
        [MTParameter(Order = 7, FlagBitId = 0, FlagType = FlagType.Null)]
        public TLVector<TLAbsPhotoSize> Thumbs { get; set; }
        [MTParameter(Order = 8, FlagBitId = 1, FlagType = FlagType.Null)]
        public TLVector<MTSharp.Schema.TL.TLVideoSize> VideoThumbs { get; set; }
        [MTParameter(Order = 9)]
        public int DcId { get; set; }
        [MTParameter(Order = 10)]
        public TLVector<TLAbsDocumentAttribute> Attributes { get; set; }


    }
}
