using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Messages
{
    [MTObject(0x327a30cb)]
    public class TLSaveGif : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x327a30cb;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputDocument Id { get; set; }
        [MTParameter(Order = 1)]
        public bool Unsave { get; set; }


    }
}
