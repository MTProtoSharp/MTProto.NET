using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xa384b779)]
    public class TLReceivedNotifyMessage : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xa384b779;
            }
        }

        [MTParameter(Order = 0)]
        public int Id { get; set; }
        [MTParameter(Order = 1)]
        public int Flags { get; set; }


    }
}
