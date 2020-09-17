using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Account
{
    [MTObject(0x899fe31d)]
    public class TLSaveSecureValue : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x899fe31d;
            }
        }

        [MTParameter(Order = 0)]
        public MTSharp.Schema.TL.TLInputSecureValue Value { get; set; }
        [MTParameter(Order = 1)]
        public long SecureSecretId { get; set; }


    }
}
