using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xcbc7ee28)]
    public class TLInputSecureFileLocation : TLAbsInputFileLocation
    {
        public override uint Constructor
        {
            get
            {
                return 0xcbc7ee28;
            }
        }

        [MTParameter(Order = 0)]
        public long Id { get; set; }
        [MTParameter(Order = 1)]
        public long AccessHash { get; set; }


    }
}
