﻿#pragma checksum "..\..\..\View\ShowProduct.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "43AD5E7108FD1F0B9AB5A09AEC463364500DDFEC9A06ECF3B610394857BEC232"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
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
using e_commerce.View;


namespace e_commerce.View {
    
    
    /// <summary>
    /// ShowProduct
    /// </summary>
    public partial class ShowProduct : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\View\ShowProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SelectBtn;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\View\ShowProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpdateBtn;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\View\ShowProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button InsertBtn;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\View\ShowProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteBtn;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\View\ShowProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Product;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\View\ShowProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox price_txt;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\View\ShowProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox name_txt;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\View\ShowProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox quantity_txt;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\View\ShowProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox description_txt;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\View\ShowProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox search_txt;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\View\ShowProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
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
            System.Uri resourceLocater = new System.Uri("/e-commerce;component/view/showproduct.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\ShowProduct.xaml"
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
            this.SelectBtn = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\View\ShowProduct.xaml"
            this.SelectBtn.Click += new System.Windows.RoutedEventHandler(this.Select_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.UpdateBtn = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\View\ShowProduct.xaml"
            this.UpdateBtn.Click += new System.Windows.RoutedEventHandler(this.Update_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.InsertBtn = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\View\ShowProduct.xaml"
            this.InsertBtn.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DeleteBtn = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\View\ShowProduct.xaml"
            this.DeleteBtn.Click += new System.Windows.RoutedEventHandler(this.DeleteBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Product = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.price_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.name_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.quantity_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.description_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.search_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\View\ShowProduct.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

