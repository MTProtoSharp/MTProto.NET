using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x16115a96)]
    public class TLPageBlockRelatedArticles : TLAbsPageBlock
    {
        public override uint Constructor
        {
            get
            {
                return 0x16115a96;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsRichText Title { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<MTSharp.Schema.TL.TLPageRelatedArticle> Articles { get; set; }


    }
}
