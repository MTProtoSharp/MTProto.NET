using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x4a70994c)]
    public class TLEncryptedFile : TLAbsEncryptedFile
    {
        public override uint Constructor
        {
            get
            {
                return 0x4a70994c;
            }
        }

        [MTParameter(Order = 0)]
        public long Id { get; set; }
        [MTParameter(Order = 1)]
        public long AccessHash { get; set; }
        [MTParameter(Order = 2)]
        public int Size { get; set; }
        [MTParameter(Order = 3)]
        public int DcId { get; set; }
        [MTParameter(Order = 4)]
        public int KeyFingerprint { get; set; }


    }
}
