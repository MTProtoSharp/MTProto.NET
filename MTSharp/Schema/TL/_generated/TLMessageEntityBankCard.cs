using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x761e6af4)]
    public class TLMessageEntityBankCard : TLAbsMessageEntity
    {
        public override uint Constructor
        {
            get
            {
                return 0x761e6af4;
            }
        }

        [MTParameter(Order = 0)]
        public int Offset { get; set; }
        [MTParameter(Order = 1)]
        public int Length { get; set; }


    }
}
