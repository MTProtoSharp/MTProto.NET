using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0xc563c1e4)]
    public class TLUpdateDialogFiltersOrder : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xc563c1e4;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<int> Order { get; set; }


    }
}
