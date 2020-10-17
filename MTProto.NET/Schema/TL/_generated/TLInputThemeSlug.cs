using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xf5890df1)]
    public class TLInputThemeSlug : TLAbsInputTheme
    {
        public override uint Constructor
        {
            get
            {
                return 0xf5890df1;
            }
        }

        [MTParameter(Order = 0)]
        public string Slug { get; set; }


    }
}
