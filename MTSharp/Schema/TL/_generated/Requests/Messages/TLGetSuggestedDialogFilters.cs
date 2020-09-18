using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MTSharp;
using MTSharp.Attributes;
using MTSharp.Enums;
using MTSharp.Schema;
using MTSharp.Schema.TL;

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0xa29cd42c)]
    public class TLGetSuggestedDialogFilters : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xa29cd42c;
            }
        }



    }
}
