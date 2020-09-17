using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Messages
{
    [MTObject(0xf0e3e596)]
    public class TLDialogsNotModified : TLAbsDialogs
    {
        public override uint Constructor
        {
            get
            {
                return 0xf0e3e596;
            }
        }

        [MTParameter(Order = 0)]
        public int Count { get; set; }


    }
}
