using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xc4b9f9bb)]
    public class TLError : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xc4b9f9bb;
            }
        }

        [MTParameter(Order = 0)]
        public int Code { get; set; }
        [MTParameter(Order = 1)]
        public string Text { get; set; }


    }
}
