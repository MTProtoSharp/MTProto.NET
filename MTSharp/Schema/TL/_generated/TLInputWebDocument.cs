using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x9bed434d)]
    public class TLInputWebDocument : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x9bed434d;
            }
        }

        [MTParameter(Order = 0)]
        public string Url { get; set; }
        [MTParameter(Order = 1)]
        public int Size { get; set; }
        [MTParameter(Order = 2)]
        public string MimeType { get; set; }
        [MTParameter(Order = 3)]
        public TLVector<TLAbsDocumentAttribute> Attributes { get; set; }


    }
}
