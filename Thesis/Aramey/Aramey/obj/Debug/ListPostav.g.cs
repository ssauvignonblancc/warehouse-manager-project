﻿#pragma checksum "..\..\ListPostav.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3036213AD6A7B200B9E84BE75D6562E8E1F376AA94517535331522980E2D4114"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Aramey;
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


namespace Aramey {
    
    
    /// <summary>
    /// ListPostav
    /// </summary>
    public partial class ListPostav : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\ListPostav.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextSearch;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\ListPostav.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Search;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\ListPostav.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid поставщикDataGrid;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\ListPostav.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn названиеColumn;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\ListPostav.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn ВидТехникиColumn;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\ListPostav.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn АдресColumn;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\ListPostav.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn НомерТелефонаColumn;
        
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
            System.Uri resourceLocater = new System.Uri("/Aramey;component/listpostav.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ListPostav.xaml"
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
            
            #line 8 "..\..\ListPostav.xaml"
            ((Aramey.ListPostav)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 8 "..\..\ListPostav.xaml"
            ((Aramey.ListPostav)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.Window_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 15 "..\..\ListPostav.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TextSearch = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Search = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\ListPostav.xaml"
            this.Search.Click += new System.Windows.RoutedEventHandler(this.Search_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.поставщикDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.названиеColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 7:
            this.ВидТехникиColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 8:
            this.АдресColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 9:
            this.НомерТелефонаColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
