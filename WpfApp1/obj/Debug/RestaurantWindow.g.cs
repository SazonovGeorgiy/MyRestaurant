﻿#pragma checksum "..\..\RestaurantWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0DA8122C87EF83B553FFC1B19E99004C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// RestaurantWindow
    /// </summary>
    public partial class RestaurantWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\RestaurantWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox timeForBooking;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\RestaurantWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox tables;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\RestaurantWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Name1;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\RestaurantWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Metro1;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\RestaurantWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddFav;
        
        #line default
        #line hidden
        
        
        #line 179 "..\..\RestaurantWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Name;
        
        #line default
        #line hidden
        
        
        #line 184 "..\..\RestaurantWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Metro;
        
        #line default
        #line hidden
        
        
        #line 189 "..\..\RestaurantWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Adress;
        
        #line default
        #line hidden
        
        
        #line 194 "..\..\RestaurantWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Phone;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/restaurantwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\RestaurantWindow.xaml"
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
            this.timeForBooking = ((System.Windows.Controls.ComboBox)(target));
            
            #line 36 "..\..\RestaurantWindow.xaml"
            this.timeForBooking.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Time_Selected);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tables = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.Name1 = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.Metro1 = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.AddFav = ((System.Windows.Controls.Button)(target));
            
            #line 118 "..\..\RestaurantWindow.xaml"
            this.AddFav.Click += new System.Windows.RoutedEventHandler(this.AddFav_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 128 "..\..\RestaurantWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Booking);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 143 "..\..\RestaurantWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Back);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Name = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.Metro = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.Adress = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.Phone = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
