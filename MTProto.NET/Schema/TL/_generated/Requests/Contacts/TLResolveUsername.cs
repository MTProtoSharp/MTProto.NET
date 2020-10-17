using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Contacts
{
    [MTObject(0xf93ccba3)]
    public class TLResolveUsername : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xf93ccba3;
            }
        }

        [MTParameter(Order = 0)]
        public string Username { get; set; }


    }
}
