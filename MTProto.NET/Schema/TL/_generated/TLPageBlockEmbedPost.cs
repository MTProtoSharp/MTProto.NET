using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xf259a80b)]
    public class TLPageBlockEmbedPost : TLAbsPageBlock
    {
        public override uint Constructor
        {
            get
            {
                return 0xf259a80b;
            }
        }

        [MTParameter(Order = 0)]
        public string Url { get; set; }
        [MTParameter(Order = 1)]
        public long WebpageId { get; set; }
        [MTParameter(Order = 2)]
        public long AuthorPhotoId { get; set; }
        [MTParameter(Order = 3)]
        public string Author { get; set; }
        [MTParameter(Order = 4)]
        public int Date { get; set; }
        [MTParameter(Order = 5)]
        public TLVector<TLAbsPageBlock> Blocks { get; set; }
        [MTParameter(Order = 6)]
        public MTProto.NET.Schema.TL.TLPageCaption Caption { get; set; }


    }
}
