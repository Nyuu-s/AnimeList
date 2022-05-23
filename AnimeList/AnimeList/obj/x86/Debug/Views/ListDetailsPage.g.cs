﻿#pragma checksum "C:\Projects\AnimeList\AnimeList\AnimeList\Views\ListDetailsPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BA708A6A819003FDCE1B0CBC44DB866A411B867A3AC77F9A8619B0B60866D90A"
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
    partial class ListDetailsPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Microsoft_Toolkit_Uwp_UI_Controls_ListDetailsView_SelectedItem(global::Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.SelectedItem = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class ListDetailsPage_obj7_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IListDetailsPage_Bindings
        {
            private global::AnimeList.Core.Models.Anime dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj7;
            private global::Windows.UI.Xaml.Controls.TextBlock obj8;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj8TextDisabled = false;

            public ListDetailsPage_obj7_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 24 && columnNumber == 71)
                {
                    isobj8TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 7: // Views\ListDetailsPage.xaml line 14
                        this.obj7 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.Grid)target);
                        break;
                    case 8: // Views\ListDetailsPage.xaml line 24
                        this.obj8 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (this.obj7.Target as global::Windows.UI.Xaml.Controls.Grid).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::AnimeList.Core.Models.Anime) item, 1 << phase);
            }

            public void Recycle()
            {
            }

            // IListDetailsPage_Bindings

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
                    this.dataRoot = (global::AnimeList.Core.Models.Anime)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::AnimeList.Core.Models.Anime obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Name(obj.Name, phase);
                    }
                }
            }
            private void Update_Name(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\ListDetailsPage.xaml line 24
                    if (!isobj8TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj8, obj, null);
                    }
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class ListDetailsPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IListDetailsPage_Bindings
        {
            private global::AnimeList.Views.ListDetailsPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView obj10;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj10ItemsSourceDisabled = false;
            private static bool isobj10SelectedItemDisabled = false;

            private ListDetailsPage_obj1_BindingsTracking bindingsTracking;

            public ListDetailsPage_obj1_Bindings()
            {
                this.bindingsTracking = new ListDetailsPage_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 65 && columnNumber == 13)
                {
                    isobj10ItemsSourceDisabled = true;
                }
                else if (lineNumber == 69 && columnNumber == 13)
                {
                    isobj10SelectedItemDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 10: // Views\ListDetailsPage.xaml line 58
                        this.obj10 = (global::Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView)target;
                        this.bindingsTracking.RegisterTwoWayListener_10(this.obj10);
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

            // IListDetailsPage_Bindings

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
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::AnimeList.Views.ListDetailsPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::AnimeList.Views.ListDetailsPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel(obj.ViewModel, phase);
                    }
                }
            }
            private void Update_ViewModel(global::AnimeList.ViewModels.ListDetailsViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_AnimesItems(obj.AnimesItems, phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_Selected(obj.Selected, phase);
                    }
                }
            }
            private void Update_ViewModel_AnimesItems(global::System.Collections.ObjectModel.ObservableCollection<global::AnimeList.Core.Models.Anime> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\ListDetailsPage.xaml line 58
                    if (!isobj10ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj10, obj, null);
                    }
                }
            }
            private void Update_ViewModel_Selected(global::AnimeList.Core.Models.Anime obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\ListDetailsPage.xaml line 58
                    if (!isobj10SelectedItemDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_Toolkit_Uwp_UI_Controls_ListDetailsView_SelectedItem(this.obj10, obj, null);
                    }
                }
            }
            private void UpdateTwoWay_10_SelectedItem()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        if (this.dataRoot.ViewModel != null)
                        {
                            this.dataRoot.ViewModel.Selected = (global::AnimeList.Core.Models.Anime)this.obj10.SelectedItem;
                        }
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class ListDetailsPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<ListDetailsPage_obj1_Bindings> weakRefToBindingObj; 

                public ListDetailsPage_obj1_BindingsTracking(ListDetailsPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<ListDetailsPage_obj1_Bindings>(obj);
                }

                public ListDetailsPage_obj1_Bindings TryGetBindingObject()
                {
                    ListDetailsPage_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_ViewModel(null);
                }

                public void PropertyChanged_ViewModel(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    ListDetailsPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::AnimeList.ViewModels.ListDetailsViewModel obj = sender as global::AnimeList.ViewModels.ListDetailsViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_ViewModel_Selected(obj.Selected, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "Selected":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_Selected(obj.Selected, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::AnimeList.ViewModels.ListDetailsViewModel cache_ViewModel = null;
                public void UpdateChildListeners_ViewModel(global::AnimeList.ViewModels.ListDetailsViewModel obj)
                {
                    if (obj != cache_ViewModel)
                    {
                        if (cache_ViewModel != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ViewModel).PropertyChanged -= PropertyChanged_ViewModel;
                            cache_ViewModel = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewModel = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ViewModel;
                        }
                    }
                }
                public void RegisterTwoWayListener_10(global::Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView.SelectedItemProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_10_SelectedItem();
                        }
                    });
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
            case 9: // Views\ListDetailsPage.xaml line 57
                {
                    this.ContentArea = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 10: // Views\ListDetailsPage.xaml line 58
                {
                    this.ListDetailsViewControl = (global::Microsoft.Toolkit.Uwp.UI.Controls.ListDetailsView)(target);
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
            case 1: // Views\ListDetailsPage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    ListDetailsPage_obj1_Bindings bindings = new ListDetailsPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            case 7: // Views\ListDetailsPage.xaml line 14
                {                    
                    global::Windows.UI.Xaml.Controls.Grid element7 = (global::Windows.UI.Xaml.Controls.Grid)target;
                    ListDetailsPage_obj7_Bindings bindings = new ListDetailsPage_obj7_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element7.DataContext);
                    element7.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element7, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element7, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

