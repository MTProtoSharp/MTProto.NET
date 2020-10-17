using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xbad07584)]
    public class TLInputDocumentFileLocation : TLAbsInputFileLocation
    {
        public override uint Constructor
        {
            get
            {
                return 0xbad07584;
            }
        }

        [MTParameter(Order = 0)]
        public long Id { get; set; }
        [MTParameter(Order = 1)]
        public long AccessHash { get; set; }
        [MTParameter(Order = 2)]
        public byte[] FileReference { get; set; }
        [MTParameter(Order = 3)]
        public string ThumbSize { get; set; }


    }
}
