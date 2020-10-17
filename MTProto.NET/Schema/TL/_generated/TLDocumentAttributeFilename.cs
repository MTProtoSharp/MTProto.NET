using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x15590068)]
    public class TLDocumentAttributeFilename : TLAbsDocumentAttribute
    {
        public override uint Constructor
        {
            get
            {
                return 0x15590068;
            }
        }

        [MTParameter(Order = 0)]
        public string FileName { get; set; }


    }
}
