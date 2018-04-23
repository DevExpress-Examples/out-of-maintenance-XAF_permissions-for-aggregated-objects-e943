using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

using DevExpress.ExpressApp;

namespace AggregatedObjects.Module.Win {
    [ToolboxItemFilter("Xaf.Platform.Win")]
    public sealed partial class AggregatedObjectsWindowsFormsModule : ModuleBase {
        public AggregatedObjectsWindowsFormsModule() {
            InitializeComponent();
        }
    }
}
