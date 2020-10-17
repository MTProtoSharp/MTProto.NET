using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x2dc173c8)]
    public class TLInputEncryptedFileBigUploaded : TLAbsInputEncryptedFile
    {
        public override uint Constructor
        {
            get
            {
                return 0x2dc173c8;
            }
        }

        [MTParameter(Order = 0)]
        public long Id { get; set; }
        [MTParameter(Order = 1)]
        public int Parts { get; set; }
        [MTParameter(Order = 2)]
        public int KeyFingerprint { get; set; }


    }
}
