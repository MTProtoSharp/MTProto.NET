using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xc27ac8c7)]
    public class TLBotCommand : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xc27ac8c7;
            }
        }

        [MTParameter(Order = 0)]
        public string Command { get; set; }
        [MTParameter(Order = 1)]
        public string Description { get; set; }


    }
}
