using System;
using System.Collections.Generic;
using System.Text;

using FastStructure.LAF.Core.LAFActions;
using FastStructure.LAF.Core;

namespace FastStructure.FastStructureAction
{
    public class LoadRequestFormAction : AbstractAction
    {
        public override void Execute()
        {
            LAFManager.GetInstance().RequestForm("REQUEST-FORM");
        }
    }
}