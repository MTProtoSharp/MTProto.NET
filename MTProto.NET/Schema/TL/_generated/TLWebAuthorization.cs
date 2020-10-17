using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xcac943f2)]
    public class TLWebAuthorization : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xcac943f2;
            }
        }

        [MTParameter(Order = 0)]
        public long Hash { get; set; }
        [MTParameter(Order = 1)]
        public int BotId { get; set; }
        [MTParameter(Order = 2)]
        public string Domain { get; set; }
        [MTParameter(Order = 3)]
        public string Browser { get; set; }
        [MTParameter(Order = 4)]
        public string Platform { get; set; }
        [MTParameter(Order = 5)]
        public int DateCreated { get; set; }
        [MTParameter(Order = 6)]
        public int DateActive { get; set; }
        [MTParameter(Order = 7)]
        public string Ip { get; set; }
        [MTParameter(Order = 8)]
        public string Region { get; set; }


    }
}
