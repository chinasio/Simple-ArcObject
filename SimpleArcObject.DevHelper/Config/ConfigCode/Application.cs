using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace SAO.DevHelper.Config.Config
{

    public partial class Application
    {
        public Application(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
