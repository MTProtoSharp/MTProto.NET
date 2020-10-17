using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Auth
{
    [MTObject(0x9fab0d1a)]
    public class TLResetAuthorizations : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x9fab0d1a;
            }
        }



    }
}
