﻿#pragma checksum "..\..\ListTechnics.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9133E5DBD40B3B7FC7457078EF7C7B07CCCB27AE0B9C70AD6CFB9034C9895452"
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
    /// ListTechnics
    /// </summary>
    public partial class ListTechnics : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\ListTechnics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LoadBD_Copy;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\ListTechnics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextSearch;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\ListTechnics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Search;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\ListTechnics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid техникаDataGrid;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\ListTechnics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn названиеColumn;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\ListTechnics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn стоимостьColumn;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\ListTechnics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTemplateColumn времяЗаписиColumn;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\ListTechnics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn поставщикColumn;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\ListTechnics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn количествоColumn;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\ListTechnics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox count;
        
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
            System.Uri resourceLocater = new System.Uri("/Aramey;component/listtechnics.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ListTechnics.xaml"
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
            
            #line 8 "..\..\ListTechnics.xaml"
            ((Aramey.ListTechnics)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LoadBD_Copy = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\ListTechnics.xaml"
            this.LoadBD_Copy.Click += new System.Windows.RoutedEventHandler(this.LoadBD_Copy_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TextSearch = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Search = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\ListTechnics.xaml"
            this.Search.Click += new System.Windows.RoutedEventHandler(this.Search_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 18 "..\..\ListTechnics.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.техникаDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.названиеColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 8:
            this.стоимостьColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 9:
            this.времяЗаписиColumn = ((System.Windows.Controls.DataGridTemplateColumn)(target));
            return;
            case 10:
            this.поставщикColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 11:
            this.количествоColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 12:
            this.count = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
