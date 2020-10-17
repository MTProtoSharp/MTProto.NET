using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Storage
{
    [MTObject(0x40bc6f52)]
    public class TLFilePartial : TLAbsFileType
    {
        public override uint Constructor
        {
            get
            {
                return 0x40bc6f52;
            }
        }



    }
}
