using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xf5235d55)]
    public class TLInputEncryptedFileLocation : TLAbsInputFileLocation
    {
        public override uint Constructor
        {
            get
            {
                return 0xf5235d55;
            }
        }

        [MTParameter(Order = 0)]
        public long Id { get; set; }
        [MTParameter(Order = 1)]
        public long AccessHash { get; set; }


    }
}
