﻿#pragma checksum "..\..\..\Views\ExportAsImage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "56F4C663EFE0656311C01969681DE2716B78A47C7885FA519BBB7EE81339A2AE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Syncfusion;
using Syncfusion.Windows;
using Syncfusion.Windows.Controls.Input;
using Syncfusion.Windows.Controls.Notification;
using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Tools;
using Syncfusion.Windows.Tools.Controls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using syncfusion.pdfviewerdemos.wpf;


namespace syncfusion.pdfviewerdemos.wpf {
    
    
    /// <summary>
    /// ExportAsImage
    /// </summary>
    public partial class ExportAsImage : Syncfusion.Windows.Shared.ChromelessWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\Views\ExportAsImage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image1;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Views\ExportAsImage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton allRadioBtn;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Views\ExportAsImage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rangeRadioButton;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\Views\ExportAsImage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel rangeStackPanel;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\Views\ExportAsImage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextFrom;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\Views\ExportAsImage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBoxFrom;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\Views\ExportAsImage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextTo;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\Views\ExportAsImage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBoxTo;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/syncfusion.pdfviewerdemos.wpf;component/views/exportasimage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\ExportAsImage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.image1 = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.allRadioBtn = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 3:
            this.rangeRadioButton = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 4:
            this.rangeStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 5:
            this.TextFrom = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.comboBoxFrom = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.TextTo = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.comboBoxTo = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
