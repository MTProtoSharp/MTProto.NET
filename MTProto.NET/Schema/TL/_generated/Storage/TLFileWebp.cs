using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Storage
{
    [MTObject(0x1081464c)]
    public class TLFileWebp : TLAbsFileType
    {
        public override uint Constructor
        {
            get
            {
                return 0x1081464c;
            }
        }



    }
}
