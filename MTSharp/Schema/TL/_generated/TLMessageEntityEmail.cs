using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x64e475c2)]
    public class TLMessageEntityEmail : TLAbsMessageEntity
    {
        public override uint Constructor
        {
            get
            {
                return 0x64e475c2;
            }
        }

        [MTParameter(Order = 0)]
        public int Offset { get; set; }
        [MTParameter(Order = 1)]
        public int Length { get; set; }


    }
}
