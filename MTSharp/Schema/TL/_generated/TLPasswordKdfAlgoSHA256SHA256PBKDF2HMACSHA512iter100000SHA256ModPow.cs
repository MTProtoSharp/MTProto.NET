using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x3a912d4a)]
    public class TLPasswordKdfAlgoSHA256SHA256PBKDF2HMACSHA512iter100000SHA256ModPow : TLAbsPasswordKdfAlgo
    {
        public override uint Constructor
        {
            get
            {
                return 0x3a912d4a;
            }
        }

        [MTParameter(Order = 0)]
        public byte[] Salt1 { get; set; }
        [MTParameter(Order = 1)]
        public byte[] Salt2 { get; set; }
        [MTParameter(Order = 2)]
        public int G { get; set; }
        [MTParameter(Order = 3)]
        public byte[] P { get; set; }


    }
}
