using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x72091c80)]
    public class TLInputWallPaperSlug : TLAbsInputWallPaper
    {
        public override uint Constructor
        {
            get
            {
                return 0x72091c80;
            }
        }

        [MTParameter(Order = 0)]
        public string Slug { get; set; }


    }
}
