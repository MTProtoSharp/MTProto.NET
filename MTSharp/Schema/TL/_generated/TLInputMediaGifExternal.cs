using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x4843b0fd)]
    public class TLInputMediaGifExternal : TLAbsInputMedia
    {
        public override uint Constructor
        {
            get
            {
                return 0x4843b0fd;
            }
        }

        [MTParameter(Order = 0)]
        public string Url { get; set; }
        [MTParameter(Order = 1)]
        public string Q { get; set; }


    }
}
