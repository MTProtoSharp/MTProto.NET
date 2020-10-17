using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x83e5de54)]
    public class TLMessageEmpty : TLAbsMessage
    {
        public override uint Constructor
        {
            get
            {
                return 0x83e5de54;
            }
        }

        [MTParameter(Order = 0)]
        public int Id { get; set; }


    }
}
