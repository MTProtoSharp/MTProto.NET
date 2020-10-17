using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0xeba80ff0)]
    public class TLGetAllChats : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xeba80ff0;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<int> ExceptIds { get; set; }


    }
}
