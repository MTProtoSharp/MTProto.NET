using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Photos
{
    [MTObject(0x72d4742c)]
    public class TLUpdateProfilePhoto : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x72d4742c;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputPhoto Id { get; set; }


    }
}
