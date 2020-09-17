using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xb4a2e88d)]
    public class TLUpdateEncryption : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0xb4a2e88d;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsEncryptedChat Chat { get; set; }
        [MTParameter(Order = 1)]
        public int Date { get; set; }


    }
}
