﻿#pragma checksum "..\..\..\Ventanas\Registrarse.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3B4F708F1C59BEF7A7015DB067F0F8563DA179EA31F0F76CACB728F98187D7BA"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using ProyectoProgra3.Ventanas;
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


namespace ProyectoProgra3.Ventanas {
    
    
    /// <summary>
    /// Registrarse
    /// </summary>
    public partial class Registrarse : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\Ventanas\Registrarse.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_usuario;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Ventanas\Registrarse.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox pwb_contrasenia;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Ventanas\Registrarse.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txt_repassword;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Ventanas\Registrarse.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_Nombre;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Ventanas\Registrarse.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_Apellido;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Ventanas\Registrarse.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_registrar;
        
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
            System.Uri resourceLocater = new System.Uri("/ProyectoProgra3;component/ventanas/registrarse.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Ventanas\Registrarse.xaml"
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
            this.txt_usuario = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.pwb_contrasenia = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 3:
            this.txt_repassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 4:
            this.txt_Nombre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txt_Apellido = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btn_registrar = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\Ventanas\Registrarse.xaml"
            this.btn_registrar.Click += new System.Windows.RoutedEventHandler(this.btn_registrar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

