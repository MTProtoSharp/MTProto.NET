using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Account
{
    [MTObject(0x3076c4bf)]
    public class TLUnregisterDevice : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x3076c4bf;
            }
        }

        [MTParameter(Order = 0)]
        public int TokenType { get; set; }
        [MTParameter(Order = 1)]
        public string Token { get; set; }
        [MTParameter(Order = 2)]
        public TLVector<int> OtherUids { get; set; }


    }
}
