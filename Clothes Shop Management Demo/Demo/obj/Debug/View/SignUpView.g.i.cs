﻿#pragma checksum "..\..\..\View\SignUpView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4246A6B508937BEAEA05035702E72A4D2B522CBE7F64A061213F84623DBAD243"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Demo.View;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using System.Windows.Interactivity;
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


namespace Demo.View {
    
    
    /// <summary>
    /// SignUpView
    /// </summary>
    public partial class SignUpView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\View\SignUpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Demo.View.SignUpView SignUpWd;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\View\SignUpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.ImageBrush ProfilePicture;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\..\View\SignUpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox User;
        
        #line default
        #line hidden
        
        
        #line 139 "..\..\..\View\SignUpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox password;
        
        #line default
        #line hidden
        
        
        #line 171 "..\..\..\View\SignUpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TenND;
        
        #line default
        #line hidden
        
        
        #line 176 "..\..\..\View\SignUpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox GT;
        
        #line default
        #line hidden
        
        
        #line 196 "..\..\..\View\SignUpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker NS;
        
        #line default
        #line hidden
        
        
        #line 210 "..\..\..\View\SignUpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SDT;
        
        #line default
        #line hidden
        
        
        #line 221 "..\..\..\View\SignUpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Mail;
        
        #line default
        #line hidden
        
        
        #line 233 "..\..\..\View\SignUpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DC;
        
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
            System.Uri resourceLocater = new System.Uri("/Demo;component/view/signupview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\SignUpView.xaml"
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
            this.SignUpWd = ((Demo.View.SignUpView)(target));
            return;
            case 2:
            
            #line 58 "..\..\..\View\SignUpView.xaml"
            ((MaterialDesignThemes.Wpf.PackIcon)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.MinimizeButton);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 66 "..\..\..\View\SignUpView.xaml"
            ((MaterialDesignThemes.Wpf.PackIcon)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.CloseButton);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ProfilePicture = ((System.Windows.Media.ImageBrush)(target));
            return;
            case 5:
            this.User = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.password = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 7:
            this.TenND = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.GT = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.NS = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 10:
            this.SDT = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.Mail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.DC = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

