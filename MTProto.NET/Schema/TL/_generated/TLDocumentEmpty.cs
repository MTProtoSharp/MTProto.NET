using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x36f8c871)]
    public class TLDocumentEmpty : TLAbsDocument
    {
        public override uint Constructor
        {
            get
            {
                return 0x36f8c871;
            }
        }

        [MTParameter(Order = 0)]
        public long Id { get; set; }


    }
}
