﻿#pragma checksum "C:\Users\Adnan\Desktop\Cetvrti semestar\OOAD Projekt\Projekt\ETFKupon\ETFKupon\Interface\DodavanjeInteresa.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "AC495638193D8CB382EE5C3D79BAD838"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ETFKupon.Interface
{
    partial class DodavanjeInteresa : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.InteresLayout = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 2:
                {
                    this.comboBoxInteresi = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 3:
                {
                    this.buttonDodajInterese = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 4:
                {
                    this.buttonPocetnaKupcaInteresi = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 16 "..\..\..\Interface\DodavanjeInteresa.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.buttonPocetnaKupcaInteresi).Click += this.buttonPocetnaKupcaInteresi_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

