using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0xd0a48c4)]
    public class TLGetCommonChats : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xd0a48c4;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputUser UserId { get; set; }
        [MTParameter(Order = 1)]
        public int MaxId { get; set; }
        [MTParameter(Order = 2)]
        public int Limit { get; set; }


    }
}
