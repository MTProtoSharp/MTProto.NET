using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x12bcbd9a)]
    public class TLUpdateNewEncryptedMessage : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x12bcbd9a;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsEncryptedMessage Message { get; set; }
        [MTParameter(Order = 1)]
        public int Qts { get; set; }


    }
}
