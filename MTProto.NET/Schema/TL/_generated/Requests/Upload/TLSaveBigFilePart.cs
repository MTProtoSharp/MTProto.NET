using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Upload
{
    [MTObject(0xde7b673d)]
    public class TLSaveBigFilePart : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xde7b673d;
            }
        }

        [MTParameter(Order = 0)]
        public long FileId { get; set; }
        [MTParameter(Order = 1)]
        public int FilePart { get; set; }
        [MTParameter(Order = 2)]
        public int FileTotalParts { get; set; }
        [MTParameter(Order = 3)]
        public byte[] Bytes { get; set; }


    }
}
