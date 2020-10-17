using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Updates
{
    [MTObject(0xa56c2a3e)]
    public class TLState : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xa56c2a3e;
            }
        }

        [MTParameter(Order = 0)]
        public int Pts { get; set; }
        [MTParameter(Order = 1)]
        public int Qts { get; set; }
        [MTParameter(Order = 2)]
        public int Date { get; set; }
        [MTParameter(Order = 3)]
        public int Seq { get; set; }
        [MTParameter(Order = 4)]
        public int UnreadCount { get; set; }


    }
}
