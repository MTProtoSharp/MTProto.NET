using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Account
{
    [MTObject(0xdd853661)]
    public class TLUploadWallPaper : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xdd853661;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputFile File { get; set; }
        [MTParameter(Order = 1)]
        public string MimeType { get; set; }
        [MTParameter(Order = 2)]
        public MTProto.NET.Schema.TL.TLWallPaperSettings Settings { get; set; }


    }
}
