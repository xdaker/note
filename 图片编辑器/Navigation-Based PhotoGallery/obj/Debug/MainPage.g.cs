﻿#pragma checksum "..\..\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DB1D1F5D9CE32EAB64701E51A918E491"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.239
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace PhotoGallery {
    
    
    /// <summary>
    /// MainPage
    /// </summary>
    public partial class MainPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\MainPage.xaml"
        internal System.Windows.Controls.Menu menu1;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\MainPage.xaml"
        internal System.Windows.Controls.MenuItem favoritesMenu;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\MainPage.xaml"
        internal System.Windows.Controls.MenuItem deleteMenu;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\MainPage.xaml"
        internal System.Windows.Controls.MenuItem renameMenu;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\MainPage.xaml"
        internal System.Windows.Controls.MenuItem fixMenu;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\MainPage.xaml"
        internal System.Windows.Controls.MenuItem printMenu;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\MainPage.xaml"
        internal System.Windows.Controls.MenuItem editMenu;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\MainPage.xaml"
        internal System.Windows.Controls.TreeView treeView;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\MainPage.xaml"
        internal System.Windows.Controls.TreeViewItem favoritesItem;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\MainPage.xaml"
        internal System.Windows.Controls.TreeViewItem foldersItem;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\MainPage.xaml"
        internal System.Windows.Controls.ListBox pictureBox;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\MainPage.xaml"
        internal System.Windows.Controls.Button zoomButton;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\MainPage.xaml"
        internal System.Windows.Controls.Primitives.Popup zoomPopup;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\MainPage.xaml"
        internal System.Windows.Controls.Slider zoomSlider;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\MainPage.xaml"
        internal System.Windows.Controls.Button defaultSizeButton;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\MainPage.xaml"
        internal System.Windows.Controls.Button previousButton;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\MainPage.xaml"
        internal System.Windows.Controls.Button slideshowButton;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\MainPage.xaml"
        internal System.Windows.Controls.Button nextButton;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\MainPage.xaml"
        internal System.Windows.Controls.Button counterclockwiseButton;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\MainPage.xaml"
        internal System.Windows.Controls.Button clockwiseButton;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\MainPage.xaml"
        internal System.Windows.Controls.Button deleteButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PhotoGallery;component/mainpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 4 "..\..\MainPage.xaml"
            ((PhotoGallery.MainPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.menu1 = ((System.Windows.Controls.Menu)(target));
            return;
            case 3:
            this.favoritesMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 31 "..\..\MainPage.xaml"
            this.favoritesMenu.Click += new System.Windows.RoutedEventHandler(this.favoritesMenu_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.deleteMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 32 "..\..\MainPage.xaml"
            this.deleteMenu.Click += new System.Windows.RoutedEventHandler(this.deleteMenu_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.renameMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 33 "..\..\MainPage.xaml"
            this.renameMenu.Click += new System.Windows.RoutedEventHandler(this.renameMenu_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 35 "..\..\MainPage.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.refreshMenu_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 37 "..\..\MainPage.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.exitMenu_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.fixMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 39 "..\..\MainPage.xaml"
            this.fixMenu.Click += new System.Windows.RoutedEventHandler(this.fixMenu_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.printMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 40 "..\..\MainPage.xaml"
            this.printMenu.Click += new System.Windows.RoutedEventHandler(this.printMenu_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.editMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 41 "..\..\MainPage.xaml"
            this.editMenu.Click += new System.Windows.RoutedEventHandler(this.editMenu_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.treeView = ((System.Windows.Controls.TreeView)(target));
            
            #line 44 "..\..\MainPage.xaml"
            this.treeView.SelectedItemChanged += new System.Windows.RoutedPropertyChangedEventHandler<object>(this.folders_SelectedItemChanged);
            
            #line default
            #line hidden
            return;
            case 12:
            this.favoritesItem = ((System.Windows.Controls.TreeViewItem)(target));
            return;
            case 13:
            this.foldersItem = ((System.Windows.Controls.TreeViewItem)(target));
            return;
            case 14:
            this.pictureBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 49 "..\..\MainPage.xaml"
            this.pictureBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.pictureBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 15:
            this.zoomButton = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\MainPage.xaml"
            this.zoomButton.Click += new System.Windows.RoutedEventHandler(this.zoomButton_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            this.zoomPopup = ((System.Windows.Controls.Primitives.Popup)(target));
            
            #line 67 "..\..\MainPage.xaml"
            this.zoomPopup.MouseLeave += new System.Windows.Input.MouseEventHandler(this.zoomPopup_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 17:
            this.zoomSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 70 "..\..\MainPage.xaml"
            this.zoomSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.zoomSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 18:
            this.defaultSizeButton = ((System.Windows.Controls.Button)(target));
            
            #line 74 "..\..\MainPage.xaml"
            this.defaultSizeButton.Click += new System.Windows.RoutedEventHandler(this.defaultSizeButton_Click);
            
            #line default
            #line hidden
            return;
            case 19:
            this.previousButton = ((System.Windows.Controls.Button)(target));
            
            #line 79 "..\..\MainPage.xaml"
            this.previousButton.Click += new System.Windows.RoutedEventHandler(this.previousButton_Click);
            
            #line default
            #line hidden
            return;
            case 20:
            this.slideshowButton = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\MainPage.xaml"
            this.slideshowButton.Click += new System.Windows.RoutedEventHandler(this.slideshowButton_Click);
            
            #line default
            #line hidden
            return;
            case 21:
            this.nextButton = ((System.Windows.Controls.Button)(target));
            
            #line 85 "..\..\MainPage.xaml"
            this.nextButton.Click += new System.Windows.RoutedEventHandler(this.nextButton_Click);
            
            #line default
            #line hidden
            return;
            case 22:
            this.counterclockwiseButton = ((System.Windows.Controls.Button)(target));
            
            #line 90 "..\..\MainPage.xaml"
            this.counterclockwiseButton.Click += new System.Windows.RoutedEventHandler(this.counterclockwiseButton_Click);
            
            #line default
            #line hidden
            return;
            case 23:
            this.clockwiseButton = ((System.Windows.Controls.Button)(target));
            
            #line 93 "..\..\MainPage.xaml"
            this.clockwiseButton.Click += new System.Windows.RoutedEventHandler(this.clockwiseButton_Click);
            
            #line default
            #line hidden
            return;
            case 24:
            this.deleteButton = ((System.Windows.Controls.Button)(target));
            
            #line 96 "..\..\MainPage.xaml"
            this.deleteButton.Click += new System.Windows.RoutedEventHandler(this.deleteButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
