﻿#pragma checksum "C:\Users\rshen\Documents\Visual Studio 2015\Projects\CaregiverMobile\CaregiverMobile\Views\Elderly_RequestPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "813D5E0E31D0F87F34314B51F16D25EC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CaregiverMobile.Views
{
    partial class Elderly_RequestPage : 
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
                    this.monitor_progressbar = (global::Windows.UI.Xaml.Controls.ProgressBar)(target);
                }
                break;
            case 2:
                {
                    this.BackBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 133 "..\..\..\Views\Elderly_RequestPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.BackBtn).Click += this.BackBtn_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.CaregiverlvBinding = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    #line 70 "..\..\..\Views\Elderly_RequestPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListView)this.CaregiverlvBinding).SelectionChanged += this.CaregiverlvBinding_SelectionChanged;
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

