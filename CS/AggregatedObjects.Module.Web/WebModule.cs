using System;
using System.ComponentModel;

using DevExpress.ExpressApp;

namespace AggregatedObjects.Module.Web {
    [ToolboxItemFilter("Xaf.Platform.Web")]
    public sealed partial class AggregatedObjectsAspNetModule : ModuleBase {
        public AggregatedObjectsAspNetModule() {
            InitializeComponent();
        }
    }
}
