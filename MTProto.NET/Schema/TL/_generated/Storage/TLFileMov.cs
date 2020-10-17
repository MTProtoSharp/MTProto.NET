using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Storage
{
    [MTObject(0x4b09ebbc)]
    public class TLFileMov : TLAbsFileType
    {
        public override uint Constructor
        {
            get
            {
                return 0x4b09ebbc;
            }
        }



    }
}
