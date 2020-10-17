using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Auth
{
    [MTObject(0x80eee427)]
    public class TLSignUp : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x80eee427;
            }
        }

        [MTParameter(Order = 0)]
        public string PhoneNumber { get; set; }
        [MTParameter(Order = 1)]
        public string PhoneCodeHash { get; set; }
        [MTParameter(Order = 2)]
        public string FirstName { get; set; }
        [MTParameter(Order = 3)]
        public string LastName { get; set; }


    }
}
