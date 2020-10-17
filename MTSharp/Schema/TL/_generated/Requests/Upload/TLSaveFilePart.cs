using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Upload
{
    [MTObject(0xb304a621)]
    public class TLSaveFilePart : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xb304a621;
            }
        }

        [MTParameter(Order = 0)]
        public long FileId { get; set; }
        [MTParameter(Order = 1)]
        public int FilePart { get; set; }
        [MTParameter(Order = 2)]
        public byte[] Bytes { get; set; }


    }
}
