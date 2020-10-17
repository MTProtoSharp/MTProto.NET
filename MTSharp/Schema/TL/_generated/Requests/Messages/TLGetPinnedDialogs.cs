using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0xd6b94df2)]
    public class TLGetPinnedDialogs : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xd6b94df2;
            }
        }

        [MTParameter(Order = 0)]
        public int FolderId { get; set; }


    }
}
