﻿#pragma checksum "..\..\TransferWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D107B0A63B0C1244E9313CA7CD00BE961ADB6AC74A18601B3E851BF146996191"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Mikhail__Moschenkov_19;
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


namespace Mikhail__Moschenkov_19 {
    
    
    /// <summary>
    /// TransferWindow
    /// </summary>
    public partial class TransferWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\TransferWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Mikhail__Moschenkov_19.ViewModelClass VM;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\TransferWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid_client;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\TransferWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button transfer_btn;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\TransferWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox transfer_sum;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\TransferWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tb_clientInfo;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\TransferWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tb_clientAccount;
        
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
            System.Uri resourceLocater = new System.Uri("/Mikhail__Moschenkov_19;component/transferwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TransferWindow.xaml"
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
            this.VM = ((Mikhail__Moschenkov_19.ViewModelClass)(target));
            return;
            case 2:
            this.dataGrid_client = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.transfer_btn = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.transfer_sum = ((System.Windows.Controls.TextBox)(target));
            
            #line 53 "..\..\TransferWindow.xaml"
            this.transfer_sum.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.transfer_sum_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tb_clientInfo = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.tb_clientAccount = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

