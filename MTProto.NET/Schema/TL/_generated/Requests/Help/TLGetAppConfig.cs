using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Help
{
    [MTObject(0x98914110)]
    public class TLGetAppConfig : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x98914110;
            }
        }



    }
}
