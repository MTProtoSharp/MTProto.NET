using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x77744d4a)]
    public class TLDialogFilterSuggested : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x77744d4a;
            }
        }

        [MTParameter(Order = 0)]
        public MTSharp.Schema.TL.TLDialogFilter Filter { get; set; }
        [MTParameter(Order = 1)]
        public string Description { get; set; }


    }
}
