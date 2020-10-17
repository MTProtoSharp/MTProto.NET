using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Account
{
    [MTObject(0x7011509f)]
    public class TLSendVerifyEmailCode : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x7011509f;
            }
        }

        [MTParameter(Order = 0)]
        public string Email { get; set; }


    }
}
