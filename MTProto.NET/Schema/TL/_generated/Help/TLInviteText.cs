using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Help
{
    [MTObject(0x18cb9f78)]
    public class TLInviteText : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x18cb9f78;
            }
        }

        [MTParameter(Order = 0)]
        public string Message { get; set; }


    }
}
