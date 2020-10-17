using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Updates
{
    [MTObject(0x5d75a138)]
    public class TLDifferenceEmpty : TLAbsDifference
    {
        public override uint Constructor
        {
            get
            {
                return 0x5d75a138;
            }
        }

        [MTParameter(Order = 0)]
        public int Date { get; set; }
        [MTParameter(Order = 1)]
        public int Seq { get; set; }


    }
}
