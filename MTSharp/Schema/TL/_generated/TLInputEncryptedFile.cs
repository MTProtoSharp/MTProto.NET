using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x5a17b5e5)]
    public class TLInputEncryptedFile : TLAbsInputEncryptedFile
    {
        public override uint Constructor
        {
            get
            {
                return 0x5a17b5e5;
            }
        }

        [MTParameter(Order = 0)]
        public long Id { get; set; }
        [MTParameter(Order = 1)]
        public long AccessHash { get; set; }


    }
}
