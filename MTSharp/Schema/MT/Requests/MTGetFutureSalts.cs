using MTSharp.Attributes;

namespace MTSharp.Schema.MT.Requests
{
    [MTObject(0xb921bd04)]
    public class MTGetFutureSalts : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xb921bd04;
            }
        }

        [MTParameter(Order = 0)]
        public int Num { get; set; }


    }
}
