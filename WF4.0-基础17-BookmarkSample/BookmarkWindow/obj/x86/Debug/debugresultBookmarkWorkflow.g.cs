﻿#pragma checksum "..\..\..\debugresultBookmarkWorkflow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "999620A998D496B46B797BE016C243BA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.21006.1
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


namespace BookmarkWindow {
    
    
    /// <summary>
    /// debugresultBookmarkWorkflow
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class debugresultBookmarkWorkflow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\..\debugresultBookmarkWorkflow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Run;
        
        #line default
        #line hidden
        
        
        #line 7 "..\..\..\debugresultBookmarkWorkflow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_triggering;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\..\debugresultBookmarkWorkflow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxBookmark;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\..\debugresultBookmarkWorkflow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox_Value;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/BookmarkWindow;component/debugresultbookmarkworkflow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\debugresultBookmarkWorkflow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.button_Run = ((System.Windows.Controls.Button)(target));
            
            #line 6 "..\..\..\debugresultBookmarkWorkflow.xaml"
            this.button_Run.Click += new System.Windows.RoutedEventHandler(this.button_Run_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.button_triggering = ((System.Windows.Controls.Button)(target));
            
            #line 7 "..\..\..\debugresultBookmarkWorkflow.xaml"
            this.button_triggering.Click += new System.Windows.RoutedEventHandler(this.button_triggering_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.textBoxBookmark = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.textBox_Value = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
