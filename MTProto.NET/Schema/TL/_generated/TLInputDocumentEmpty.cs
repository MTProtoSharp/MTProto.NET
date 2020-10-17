using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x72f0eaae)]
    public class TLInputDocumentEmpty : TLAbsInputDocument
    {
        public override uint Constructor
        {
            get
            {
                return 0x72f0eaae;
            }
        }



    }
}
