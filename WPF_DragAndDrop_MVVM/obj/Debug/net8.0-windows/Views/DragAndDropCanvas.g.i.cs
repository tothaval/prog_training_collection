﻿#pragma checksum "..\..\..\..\Views\DragAndDropCanvas.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B5F72A5001A3A1B452FF31EA7B6D436342B23EAC"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using WPF_DragAndDrop_MVVM.Views;


namespace WPF_DragAndDrop_MVVM.Views {
    
    
    /// <summary>
    /// DragAndDropCanvas
    /// </summary>
    public partial class DragAndDropCanvas : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\..\..\Views\DragAndDropCanvas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WPF_DragAndDrop_MVVM.Views.DragAndDropCanvas root;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\Views\DragAndDropCanvas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas canvas;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\Views\DragAndDropCanvas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle orangeRectangle;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPF_DragAndDrop_MVVM;component/views/draganddropcanvas.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\DragAndDropCanvas.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.root = ((WPF_DragAndDrop_MVVM.Views.DragAndDropCanvas)(target));
            return;
            case 2:
            this.canvas = ((System.Windows.Controls.Canvas)(target));
            
            #line 15 "..\..\..\..\Views\DragAndDropCanvas.xaml"
            this.canvas.Drop += new System.Windows.DragEventHandler(this.canvas_Drop);
            
            #line default
            #line hidden
            
            #line 16 "..\..\..\..\Views\DragAndDropCanvas.xaml"
            this.canvas.DragLeave += new System.Windows.DragEventHandler(this.canvas_DragLeave);
            
            #line default
            #line hidden
            
            #line 17 "..\..\..\..\Views\DragAndDropCanvas.xaml"
            this.canvas.DragOver += new System.Windows.DragEventHandler(this.canvas_DragOver);
            
            #line default
            #line hidden
            return;
            case 3:
            this.orangeRectangle = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 21 "..\..\..\..\Views\DragAndDropCanvas.xaml"
            this.orangeRectangle.MouseMove += new System.Windows.Input.MouseEventHandler(this.orangeRectangle_MouseMove);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

