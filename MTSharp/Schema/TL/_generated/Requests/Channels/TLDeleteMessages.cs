using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Channels
{
    [MTObject(0x84c1fd4e)]
    public class TLDeleteMessages : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x84c1fd4e;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputChannel Channel { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<int> Id { get; set; }


    }
}
