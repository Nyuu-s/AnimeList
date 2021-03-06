using System;
using System.Collections.Generic;
using System.Windows.Input;

using AnimeList.Helpers;
using AnimeList.Services;
using AnimeList.Views;

using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace AnimeList.ViewModels
{
    public class ShellViewModel : ObservableObject
    {
        private readonly KeyboardAccelerator _altLeftKeyboardAccelerator = BuildKeyboardAccelerator(VirtualKey.Left, VirtualKeyModifiers.Menu);
        private readonly KeyboardAccelerator _backKeyboardAccelerator = BuildKeyboardAccelerator(VirtualKey.GoBack);
        private IList<KeyboardAccelerator> _keyboardAccelerators;

        private ICommand _loadedCommand;
        private ICommand _menuFileAddCommand;
        private ICommand _menuViewsAnimeGridCommand;
        private ICommand _menuViewsListDetailsCommand;
        private ICommand _menuViewsPreviewNoticeCommand;
        private ICommand _menuFileExitCommand;

        public ICommand LoadedCommand => _loadedCommand ?? (_loadedCommand = new RelayCommand(OnLoaded));


        public ICommand MenuViewsAnimeGridCommand => _menuViewsAnimeGridCommand ?? (_menuViewsAnimeGridCommand = new RelayCommand(OnMenuViewsAnimeGrid));

        public ICommand MenuViewsListDetailsCommand => _menuViewsListDetailsCommand ?? (_menuViewsListDetailsCommand = new RelayCommand(OnMenuViewsListDetails));

       // public ICommand MenuViewsPreviewNoticeCommand => _menuViewsPreviewNoticeCommand ?? (_menuViewsPreviewNoticeCommand = new RelayCommand(OnMenuViewsPreviewNotice));

        public ICommand MenuViewsAddCommand => _menuFileAddCommand ?? (_menuFileAddCommand = new RelayCommand(OnMenuViewsMain));
        public ICommand MenuFileExitCommand => _menuFileExitCommand ?? (_menuFileExitCommand = new RelayCommand(OnMenuFileExit));

        public ShellViewModel()
        {
        }

        public void Initialize(Frame shellFrame, SplitView splitView, Frame rightFrame, IList<KeyboardAccelerator> keyboardAccelerators)
        {
            NavigationService.Frame = shellFrame;
            MenuNavigationHelper.Initialize(splitView, rightFrame);
            _keyboardAccelerators = keyboardAccelerators;
        }

        private void OnLoaded()
        {
            // Keyboard accelerators are added here to avoid showing 'Alt + left' tooltip on the page.
            // More info on tracking issue https://github.com/Microsoft/microsoft-ui-xaml/issues/8
            _keyboardAccelerators.Add(_altLeftKeyboardAccelerator);
            _keyboardAccelerators.Add(_backKeyboardAccelerator);
        }

        private void OnMenuViewsMain() => MenuNavigationHelper.UpdateView(typeof(MainPage));

        private void OnMenuViewsAnimeGrid() => MenuNavigationHelper.UpdateView(typeof(AnimeGridPage));

        private void OnMenuViewsListDetails() => MenuNavigationHelper.UpdateView(typeof(ListDetailsPage));

       // private void OnMenuViewsPreviewNotice() => MenuNavigationHelper.UpdateView(typeof(PreviewNoticePage));

        private void OnMenuFileExit()
        {
            Application.Current.Exit();
        }

        private static KeyboardAccelerator BuildKeyboardAccelerator(VirtualKey key, VirtualKeyModifiers? modifiers = null)
        {
            var keyboardAccelerator = new KeyboardAccelerator() { Key = key };
            if (modifiers.HasValue)
            {
                keyboardAccelerator.Modifiers = modifiers.Value;
            }

            keyboardAccelerator.Invoked += OnKeyboardAcceleratorInvoked;
            return keyboardAccelerator;
        }

        private static void OnKeyboardAcceleratorInvoked(KeyboardAccelerator sender, KeyboardAcceleratorInvokedEventArgs args)
        {
            var result = NavigationService.GoBack();
            args.Handled = result;
        }
    }
}
