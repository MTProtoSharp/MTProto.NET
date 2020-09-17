using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xd83466f3)]
    public class TLInputPhotoLegacyFileLocation : TLAbsInputFileLocation
    {
        public override uint Constructor
        {
            get
            {
                return 0xd83466f3;
            }
        }

        [MTParameter(Order = 0)]
        public long Id { get; set; }
        [MTParameter(Order = 1)]
        public long AccessHash { get; set; }
        [MTParameter(Order = 2)]
        public byte[] FileReference { get; set; }
        [MTParameter(Order = 3)]
        public long VolumeId { get; set; }
        [MTParameter(Order = 4)]
        public int LocalId { get; set; }
        [MTParameter(Order = 5)]
        public long Secret { get; set; }


    }
}
