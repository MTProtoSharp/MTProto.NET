using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Help
{
    [MTObject(0x1eb3758)]
    public class TLUserInfo : TLAbsUserInfo
    {
        public override uint Constructor
        {
            get
            {
                return 0x1eb3758;
            }
        }

        [MTParameter(Order = 0)]
        public string Message { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<TLAbsMessageEntity> Entities { get; set; }
        [MTParameter(Order = 2)]
        public string Author { get; set; }
        [MTParameter(Order = 3)]
        public int Date { get; set; }


    }
}
