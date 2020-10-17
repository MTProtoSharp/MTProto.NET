using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Storage
{
    [MTObject(0x528a0677)]
    public class TLFileMp3 : TLAbsFileType
    {
        public override uint Constructor
        {
            get
            {
                return 0x528a0677;
            }
        }



    }
}
