using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Help
{
    [MTObject(0x66b91b70)]
    public class TLEditUserInfo : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x66b91b70;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputUser UserId { get; set; }
        [MTParameter(Order = 1)]
        public string Message { get; set; }
        [MTParameter(Order = 2)]
        public TLVector<TLAbsMessageEntity> Entities { get; set; }


    }
}
