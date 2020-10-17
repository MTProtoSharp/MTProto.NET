using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL.Requests.Account
{
    [MTObject(0x68976c6f)]
    public class TLRegisterDevice : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x68976c6f;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool NoMuted { get; set; }
        [MTParameter(Order = 2)]
        public int TokenType { get; set; }
        [MTParameter(Order = 3)]
        public string Token { get; set; }
        [MTParameter(Order = 4)]
        public bool AppSandbox { get; set; }
        [MTParameter(Order = 5)]
        public byte[] Secret { get; set; }
        [MTParameter(Order = 6)]
        public TLVector<int> OtherUids { get; set; }


    }
}
