﻿#pragma checksum "..\..\savepractice.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1E7E651E1304FA141719E17274C6BE0B7EA69C83369C7AB6D884838EFD13FBB7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using project2020;


namespace project2020 {
    
    
    /// <summary>
    /// savepractice
    /// </summary>
    public partial class savepractice : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\savepractice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image close;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\savepractice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image h;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\savepractice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tname;
        
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
            System.Uri resourceLocater = new System.Uri("/project2020;component/savepractice.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\savepractice.xaml"
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
            this.close = ((System.Windows.Controls.Image)(target));
            
            #line 19 "..\..\savepractice.xaml"
            this.close.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.savep_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.h = ((System.Windows.Controls.Image)(target));
            
            #line 20 "..\..\savepractice.xaml"
            this.h.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.savep_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tname = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\savepractice.xaml"
            this.tname.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tname_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

