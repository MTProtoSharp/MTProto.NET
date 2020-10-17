using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x3334b0f0)]
    public class TLInputSecureFileUploaded : TLAbsInputSecureFile
    {
        public override uint Constructor
        {
            get
            {
                return 0x3334b0f0;
            }
        }

        [MTParameter(Order = 0)]
        public long Id { get; set; }
        [MTParameter(Order = 1)]
        public int Parts { get; set; }
        [MTParameter(Order = 2)]
        public string Md5Checksum { get; set; }
        [MTParameter(Order = 3)]
        public byte[] FileHash { get; set; }
        [MTParameter(Order = 4)]
        public byte[] Secret { get; set; }


    }
}
