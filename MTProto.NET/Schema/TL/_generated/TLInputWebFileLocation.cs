using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xc239d686)]
    public class TLInputWebFileLocation : TLAbsInputWebFileLocation
    {
        public override uint Constructor
        {
            get
            {
                return 0xc239d686;
            }
        }

        [MTParameter(Order = 0)]
        public string Url { get; set; }
        [MTParameter(Order = 1)]
        public long AccessHash { get; set; }


    }
}
