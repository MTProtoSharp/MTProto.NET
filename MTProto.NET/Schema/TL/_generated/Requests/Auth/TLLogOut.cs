using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Auth
{
    [MTObject(0x5717da40)]
    public class TLLogOut : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x5717da40;
            }
        }



    }
}
