using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xbc7fc6cd)]
    public class TLFileLocationToBeDeprecated : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xbc7fc6cd;
            }
        }

        [MTParameter(Order = 0)]
        public long VolumeId { get; set; }
        [MTParameter(Order = 1)]
        public int LocalId { get; set; }


    }
}
