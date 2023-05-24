﻿using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Wpf.Ui.Common.Interfaces;

namespace XHS.Spider.ViewModels
{
    /// <summary>
    /// 搜索首页
    /// </summary>
    public class HomeExploreViewModel : ObservableObject, INavigationAware
    {
        #region 属性
        private string inputText;
        public string InputText
        {
            get => inputText;
            set => SetProperty(ref inputText, value);
        }
        // 输入确认事件
        private ICommand inputCommand;
        public ICommand InputCommand
        {
            get => inputCommand ?? (inputCommand = new Wpf.Ui.Common.RelayCommand(ExecuteInitData));
            set => inputCommand = value;
        }
        #endregion

        #region 搜索
        /// <summary>
        /// 处理输入事件
        /// </summary>
        public async void ExecuteInitData()
        {
        
        }
        #endregion
        public void OnNavigatedFrom()
        {
        }

        public void OnNavigatedTo()
        {
        }
    }
}
