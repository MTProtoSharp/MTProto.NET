using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Upload
{
    [MTObject(0x24e6818d)]
    public class TLGetWebFile : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x24e6818d;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputWebFileLocation Location { get; set; }
        [MTParameter(Order = 1)]
        public int Offset { get; set; }
        [MTParameter(Order = 2)]
        public int Limit { get; set; }


    }
}
