﻿#pragma checksum "C:\Users\jason\documents\visual studio 2015\Projects\SavingsAccumulator\SavingsAccumulator\UserControls\AddTransactionControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5ED122A687851170014BAEBD71EB6741"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SavingsAccumulator.UserControls
{
    partial class AddTransactionControl : 
        global::Windows.UI.Xaml.Controls.UserControl, 
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
                    this.AmtTxtBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 2:
                {
                    this.ConfirmBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 28 "..\..\..\UserControls\AddTransactionControl.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.ConfirmBtn).Click += this.ConfirmBtn_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.CancelBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 29 "..\..\..\UserControls\AddTransactionControl.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.CancelBtn).Click += this.CancelBtn_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.textBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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

