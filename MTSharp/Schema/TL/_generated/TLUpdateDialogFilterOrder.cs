using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xa5d72105)]
    public class TLUpdateDialogFilterOrder : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0xa5d72105;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<int> Order { get; set; }


    }
}
