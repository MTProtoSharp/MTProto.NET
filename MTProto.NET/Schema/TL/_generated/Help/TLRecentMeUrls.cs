using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Help
{
    [MTObject(0xe0310d7)]
    public class TLRecentMeUrls : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xe0310d7;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<TLAbsRecentMeUrl> Urls { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<TLAbsChat> Chats { get; set; }
        [MTParameter(Order = 2)]
        public TLVector<TLAbsUser> Users { get; set; }


    }
}
