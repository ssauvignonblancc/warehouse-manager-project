#pragma checksum "..\..\AddTechnics.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "268555880F0981FCD1EC9C073A87FB5864C1E082AEF4E660A7A36CF8DA5B3EC8"
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
    /// AddTechnics
    /// </summary>
    public partial class AddTechnics : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\AddTechnics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameTech;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\AddTechnics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PriceTech;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\AddTechnics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TimeTech;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\AddTechnics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\AddTechnics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Add;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\AddTechnics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CountTech;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\AddTechnics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox listPostav;
        
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
            System.Uri resourceLocater = new System.Uri("/Aramey;component/addtechnics.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddTechnics.xaml"
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
            
            #line 8 "..\..\AddTechnics.xaml"
            ((Aramey.AddTechnics)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.NameTech = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.PriceTech = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TimeTech = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Back = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\AddTechnics.xaml"
            this.Back.Click += new System.Windows.RoutedEventHandler(this.Back_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Add = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\AddTechnics.xaml"
            this.Add.Click += new System.Windows.RoutedEventHandler(this.Add_Click_1);
            
            #line default
            #line hidden
            return;
            case 7:
            this.CountTech = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.listPostav = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

