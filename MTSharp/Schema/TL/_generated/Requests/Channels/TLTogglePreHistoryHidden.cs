using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Channels
{
    [MTObject(0xeabbb94c)]
    public class TLTogglePreHistoryHidden : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xeabbb94c;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputChannel Channel { get; set; }
        [MTParameter(Order = 1)]
        public bool Enabled { get; set; }


    }
}
