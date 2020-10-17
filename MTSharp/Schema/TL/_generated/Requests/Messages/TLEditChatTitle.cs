using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0xdc452855)]
    public class TLEditChatTitle : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xdc452855;
            }
        }

        [MTParameter(Order = 0)]
        public int ChatId { get; set; }
        [MTParameter(Order = 1)]
        public string Title { get; set; }


    }
}
