using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x58fffcd0)]
    public class TLHighScore : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x58fffcd0;
            }
        }

        [MTParameter(Order = 0)]
        public int Pos { get; set; }
        [MTParameter(Order = 1)]
        public int UserId { get; set; }
        [MTParameter(Order = 2)]
        public int Score { get; set; }


    }
}
