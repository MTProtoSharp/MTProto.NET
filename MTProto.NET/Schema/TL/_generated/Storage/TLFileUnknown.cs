using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Storage
{
    [MTObject(0xaa963b05)]
    public class TLFileUnknown : TLAbsFileType
    {
        public override uint Constructor
        {
            get
            {
                return 0xaa963b05;
            }
        }



    }
}
