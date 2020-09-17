using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x64bd0306)]
    public class TLInputEncryptedFileUploaded : TLAbsInputEncryptedFile
    {
        public override uint Constructor
        {
            get
            {
                return 0x64bd0306;
            }
        }

        [MTParameter(Order = 0)]
        public long Id { get; set; }
        [MTParameter(Order = 1)]
        public int Parts { get; set; }
        [MTParameter(Order = 2)]
        public string Md5Checksum { get; set; }
        [MTParameter(Order = 3)]
        public int KeyFingerprint { get; set; }


    }
}
