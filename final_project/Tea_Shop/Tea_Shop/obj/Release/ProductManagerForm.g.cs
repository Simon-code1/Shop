﻿#pragma checksum "..\..\ProductManagerForm.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4F4B6C6BEBD04A3BC9F367952D3F552D9DAFFC17F5BEE1B71D6F8BC3A3474051"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DemoWPF;
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


namespace DemoWPF {
    
    
    /// <summary>
    /// ProductManagerForm
    /// </summary>
    public partial class ProductManagerForm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\ProductManagerForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridView1;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\ProductManagerForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_Description;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\ProductManagerForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_Price;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\ProductManagerForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_Inventory;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\ProductManagerForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_Type;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\ProductManagerForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_AddNew;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\ProductManagerForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Update;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\ProductManagerForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Delete;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\ProductManagerForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_EmployeeForm;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\ProductManagerForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Exit;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\ProductManagerForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Refresh;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\ProductManagerForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Statistics;
        
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
            System.Uri resourceLocater = new System.Uri("/Tea_Shop;component/productmanagerform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ProductManagerForm.xaml"
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
            this.DataGridView1 = ((System.Windows.Controls.DataGrid)(target));
            
            #line 18 "..\..\ProductManagerForm.xaml"
            this.DataGridView1.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txt_Description = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txt_Price = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txt_Inventory = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txt_Type = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btn_AddNew = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\ProductManagerForm.xaml"
            this.btn_AddNew.Click += new System.Windows.RoutedEventHandler(this.btn_AddNew_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btn_Update = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\ProductManagerForm.xaml"
            this.btn_Update.Click += new System.Windows.RoutedEventHandler(this.btn_Update_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btn_Delete = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\ProductManagerForm.xaml"
            this.btn_Delete.Click += new System.Windows.RoutedEventHandler(this.btn_Delete_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btn_EmployeeForm = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\ProductManagerForm.xaml"
            this.btn_EmployeeForm.Click += new System.Windows.RoutedEventHandler(this.btn_EmployeeForm_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btn_Exit = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\ProductManagerForm.xaml"
            this.btn_Exit.Click += new System.Windows.RoutedEventHandler(this.btn_Exit_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btn_Refresh = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\ProductManagerForm.xaml"
            this.btn_Refresh.Click += new System.Windows.RoutedEventHandler(this.btn_Refresh_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.btn_Statistics = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\ProductManagerForm.xaml"
            this.btn_Statistics.Click += new System.Windows.RoutedEventHandler(this.btn_Statistics_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

