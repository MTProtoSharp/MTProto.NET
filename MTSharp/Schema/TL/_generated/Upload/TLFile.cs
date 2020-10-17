using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Upload
{
    [MTObject(0x96a18d5)]
    public class TLFile : TLAbsFile
    {
        public override uint Constructor
        {
            get
            {
                return 0x96a18d5;
            }
        }

        [MTParameter(Order = 0)]
        public Storage.TLAbsFileType Type { get; set; }
        [MTParameter(Order = 1)]
        public int Mtime { get; set; }
        [MTParameter(Order = 2)]
        public byte[] Bytes { get; set; }


    }
}
