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

namespace MTSharp.Schema.TL.Contacts
{
    [MTObject(0xb74ba9d2)]
    public class TLContactsNotModified : TLAbsContacts
    {
        public override uint Constructor
        {
            get
            {
                return 0xb74ba9d2;
            }
        }



    }
}
