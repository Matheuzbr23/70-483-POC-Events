using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class OverDraftEventArgs : EventArgs
    {
        public decimal AmountOverDrafted { get; private set; }
        public string MoreInfo { get; private set; }
        public string ValidationInfo { get; private set; }

        public OverDraftEventArgs(decimal amountOverDrafted, string moreInfo)
        {
            AmountOverDrafted = amountOverDrafted;
            MoreInfo = moreInfo;
        }

        public OverDraftEventArgs(string validationInfo)
        {
            ValidationInfo = validationInfo;
        }

    }
}
