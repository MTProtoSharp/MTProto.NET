using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Upload
{
    [MTObject(0xf18cda44)]
    public class TLFileCdnRedirect : TLAbsFile
    {
        public override uint Constructor
        {
            get
            {
                return 0xf18cda44;
            }
        }

        [MTParameter(Order = 0)]
        public int DcId { get; set; }
        [MTParameter(Order = 1)]
        public byte[] FileToken { get; set; }
        [MTParameter(Order = 2)]
        public byte[] EncryptionKey { get; set; }
        [MTParameter(Order = 3)]
        public byte[] EncryptionIv { get; set; }
        [MTParameter(Order = 4)]
        public TLVector<MTProto.NET.Schema.TL.TLFileHash> FileHashes { get; set; }


    }
}
