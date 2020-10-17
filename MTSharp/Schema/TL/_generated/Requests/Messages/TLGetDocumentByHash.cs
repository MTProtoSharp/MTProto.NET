using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0x338e2464)]
    public class TLGetDocumentByHash : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x338e2464;
            }
        }

        [MTParameter(Order = 0)]
        public byte[] Sha256 { get; set; }
        [MTParameter(Order = 1)]
        public int Size { get; set; }
        [MTParameter(Order = 2)]
        public string MimeType { get; set; }


    }
}
