﻿#pragma checksum "C:\Users\LAU\Documents\Visual Studio 2015\Projects\CaregiverMobile\CaregiverMobile\Views\VerifyFace.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0C2B75EB0906753EBBBE4FA054B22394"
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
    partial class VerifyFace : 
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
                    this.EnrollFace = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 2:
                {
                    this.VerifyBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 109 "..\..\..\Views\VerifyFace.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.VerifyBtn).Click += this.VerifyBtn_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.FinishBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 121 "..\..\..\Views\VerifyFace.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.FinishBtn).Click += this.FinishBtn_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.LogBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5:
                {
                    global::Windows.UI.Xaml.Controls.Button element5 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 60 "..\..\..\Views\VerifyFace.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element5).Click += this.ImageTakeBtn_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.progressbar = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 7:
                {
                    this.VisualizationCanvas = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                }
                break;
            case 8:
                {
                    this.BlockFaceStatus = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 9:
                {
                    this.SkipVerifyBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 32 "..\..\..\Views\VerifyFace.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.SkipVerifyBtn).Click += this.SkipVerifyBtn_Click;
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

