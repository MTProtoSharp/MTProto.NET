using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x64199744)]
    public class TLSecureFileEmpty : TLAbsSecureFile
    {
        public override uint Constructor
        {
            get
            {
                return 0x64199744;
            }
        }



    }
}
