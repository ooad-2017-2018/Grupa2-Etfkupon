﻿#pragma checksum "C:\Users\NadjaD\Desktop\OOAD projekat\Projekt\ETFKupon\ETFKupon\Interface\PocetnaKupca.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "94F0C315E336E9EFEB529F302560BC34"
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
    partial class PocetnaKupca : 
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
                    this.buttonInteresi = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 25 "..\..\..\Interface\PocetnaKupca.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.buttonInteresi).Click += this.buttonInterface_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.buttonLogout = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 31 "..\..\..\Interface\PocetnaKupca.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.buttonLogout).Click += this.buttonLogout_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.buttonPretraga = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 4:
                {
                    this.textBoxPretraga = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5:
                {
                    this.buttonAzuriraj = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 6:
                {
                    this.buttonObrisi = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 7:
                {
                    this.textViewWellcome = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8:
                {
                    this.gridViewArtikli = (global::Windows.UI.Xaml.Controls.GridView)(target);
                }
                break;
            case 9:
                {
                    this.listViewInterface = (global::Windows.UI.Xaml.Controls.ListView)(target);
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
