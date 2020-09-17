using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xe40370a3)]
    public class TLUpdateEditMessage : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0xe40370a3;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsMessage Message { get; set; }
        [MTParameter(Order = 1)]
        public int Pts { get; set; }
        [MTParameter(Order = 2)]
        public int PtsCount { get; set; }


    }
}
