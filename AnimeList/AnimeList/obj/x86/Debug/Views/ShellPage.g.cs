﻿#pragma checksum "C:\Projects\AnimeList\AnimeList\AnimeList\Views\ShellPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BA47520EC043946BBF1FC695670E3C87B32608B9E27814BA728213AD03ABFC00"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AnimeList.Views
{
    partial class ShellPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Microsoft_Xaml_Interactions_Core_InvokeCommandAction_Command(global::Microsoft.Xaml.Interactions.Core.InvokeCommandAction obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.Command = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_MenuFlyoutItem_Command(global::Windows.UI.Xaml.Controls.MenuFlyoutItem obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.Command = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class ShellPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IShellPage_Bindings
        {
            private global::AnimeList.Views.ShellPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Microsoft.Xaml.Interactions.Core.InvokeCommandAction obj2;
            private global::Windows.UI.Xaml.Controls.MenuFlyoutItem obj6;
            private global::Windows.UI.Xaml.Controls.MenuFlyoutItem obj7;
            private global::Windows.UI.Xaml.Controls.MenuFlyoutItem obj8;
            private global::Windows.UI.Xaml.Controls.MenuFlyoutItem obj9;
            private global::Windows.UI.Xaml.Controls.MenuFlyoutItem obj10;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj2CommandDisabled = false;
            private static bool isobj6CommandDisabled = false;
            private static bool isobj7CommandDisabled = false;
            private static bool isobj8CommandDisabled = false;
            private static bool isobj9CommandDisabled = false;
            private static bool isobj10CommandDisabled = false;

            public ShellPage_obj1_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 15 && columnNumber == 37)
                {
                    isobj2CommandDisabled = true;
                }
                else if (lineNumber == 43 && columnNumber == 70)
                {
                    isobj6CommandDisabled = true;
                }
                else if (lineNumber == 44 && columnNumber == 75)
                {
                    isobj7CommandDisabled = true;
                }
                else if (lineNumber == 45 && columnNumber == 77)
                {
                    isobj8CommandDisabled = true;
                }
                else if (lineNumber == 46 && columnNumber == 79)
                {
                    isobj9CommandDisabled = true;
                }
                else if (lineNumber == 40 && columnNumber == 69)
                {
                    isobj10CommandDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // Views\ShellPage.xaml line 15
                        this.obj2 = (global::Microsoft.Xaml.Interactions.Core.InvokeCommandAction)target;
                        break;
                    case 6: // Views\ShellPage.xaml line 43
                        this.obj6 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)target;
                        break;
                    case 7: // Views\ShellPage.xaml line 44
                        this.obj7 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)target;
                        break;
                    case 8: // Views\ShellPage.xaml line 45
                        this.obj8 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)target;
                        break;
                    case 9: // Views\ShellPage.xaml line 46
                        this.obj9 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)target;
                        break;
                    case 10: // Views\ShellPage.xaml line 40
                        this.obj10 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)target;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // IShellPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::AnimeList.Views.ShellPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::AnimeList.Views.ShellPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel(obj.ViewModel, phase);
                    }
                }
            }
            private void Update_ViewModel(global::AnimeList.ViewModels.ShellViewModel obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_LoadedCommand(obj.LoadedCommand, phase);
                        this.Update_ViewModel_MenuViewsMainCommand(obj.MenuViewsMainCommand, phase);
                        this.Update_ViewModel_MenuViewsAnimeGridCommand(obj.MenuViewsAnimeGridCommand, phase);
                        this.Update_ViewModel_MenuViewsListDetailsCommand(obj.MenuViewsListDetailsCommand, phase);
                        this.Update_ViewModel_MenuViewsPreviewNoticeCommand(obj.MenuViewsPreviewNoticeCommand, phase);
                        this.Update_ViewModel_MenuFileExitCommand(obj.MenuFileExitCommand, phase);
                    }
                }
            }
            private void Update_ViewModel_LoadedCommand(global::System.Windows.Input.ICommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\ShellPage.xaml line 15
                    if (!isobj2CommandDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_Xaml_Interactions_Core_InvokeCommandAction_Command(this.obj2, obj, null);
                    }
                }
            }
            private void Update_ViewModel_MenuViewsMainCommand(global::System.Windows.Input.ICommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\ShellPage.xaml line 43
                    if (!isobj6CommandDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_MenuFlyoutItem_Command(this.obj6, obj, null);
                    }
                }
            }
            private void Update_ViewModel_MenuViewsAnimeGridCommand(global::System.Windows.Input.ICommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\ShellPage.xaml line 44
                    if (!isobj7CommandDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_MenuFlyoutItem_Command(this.obj7, obj, null);
                    }
                }
            }
            private void Update_ViewModel_MenuViewsListDetailsCommand(global::System.Windows.Input.ICommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\ShellPage.xaml line 45
                    if (!isobj8CommandDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_MenuFlyoutItem_Command(this.obj8, obj, null);
                    }
                }
            }
            private void Update_ViewModel_MenuViewsPreviewNoticeCommand(global::System.Windows.Input.ICommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\ShellPage.xaml line 46
                    if (!isobj9CommandDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_MenuFlyoutItem_Command(this.obj9, obj, null);
                    }
                }
            }
            private void Update_ViewModel_MenuFileExitCommand(global::System.Windows.Input.ICommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\ShellPage.xaml line 40
                    if (!isobj10CommandDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_MenuFlyoutItem_Command(this.obj10, obj, null);
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 3: // Views\ShellPage.xaml line 19
                {
                    this.splitView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 4: // Views\ShellPage.xaml line 24
                {
                    this.rightFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 5: // Views\ShellPage.xaml line 50
                {
                    this.shellFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // Views\ShellPage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    ShellPage_obj1_Bindings bindings = new ShellPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

