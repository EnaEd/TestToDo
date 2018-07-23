﻿using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using TestToDo.Core.Models;

namespace TestToDo.Core.ViewModels
{
    

    public class ItemViewModel : MvxViewModel
    {
        
        public static ObservableCollection<Item> ListItems { get; set; }
        
        //private MainViewModel _mainViewModel;
        //public MainViewModel MainViewModel
        //{
        //    get { return _mainViewModel; }
        //    set
        //    {
        //        if (_mainViewModel!=value)
        //        {
        //            _mainViewModel = value;
        //            RaisePropertyChanged(() => MainViewModel);
        //        }
        //    }
        //}

        public Item Item { get;set; }

        public ItemViewModel()
        {
            Item = new Item();
            if (ListItems==null)
            {
                ListItems = new ObservableCollection<Item>(); 
            }
           
        }
        


        public string TaskName
        {
            get
            {
                if (TaskContent.Length<10)
                {
                    return string.Format($"{Item.TaskContent}"); 
                }
                return string.Format($"{Item.TaskContent.Substring(0, 10)}...");
            }
        }
        public string TaskContent
        {
            get { return Item.TaskContent; }
            set
            {
                if (Item.TaskContent!=value)
                {
                    Item.TaskContent = value;
                    RaisePropertyChanged(() => TaskContent);
                    RaisePropertyChanged(() => TaskName); 
                }
            }
        }
        private MvxCommand _backToListItems;
        public System.Windows.Input.ICommand BackToListItems
        {
            get
            {
                _backToListItems = _backToListItems ?? new MvxCommand(GoBack);
                return _backToListItems;
            }
        }
        private void GoBack()
        {
            ShowViewModel<MainViewModel>();
        }
        private MvxCommand _saveItem;
        public System.Windows.Input.ICommand SaveItem
        {
            get
            {
                _saveItem = _saveItem ?? new MvxCommand(DoSaveItem);
                return _saveItem;
            }
        }
        private void DoSaveItem()
        {

            Item.TaskName = this.TaskName;
            //Item.TaskContent = this.TaskContent;
            ListItems.Add(Item);
            GoBack();
        }



    }
        
}