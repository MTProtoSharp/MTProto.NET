using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0x15a3b8e3)]
    public class TLMigrateChat : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x15a3b8e3;
            }
        }

        [MTParameter(Order = 0)]
        public int ChatId { get; set; }


    }
}
