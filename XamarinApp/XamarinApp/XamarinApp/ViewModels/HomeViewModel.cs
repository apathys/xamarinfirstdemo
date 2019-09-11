using Apathys.CalouselViewLib.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinApp.Models;

namespace XamarinApp.ViewModels
{
    public class HomeViewModel: BaseViewModel.BaseViewModel, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private int _currentIndex;
        private int _ImageCount = 1058;

        public HomeViewModel()
        {
            Items = new ObservableCollection<object>
            {
                new { Source = CreateSource(), Ind = _ImageCount++, Color = Color.Red },
                new { Source = CreateSource(), Ind = _ImageCount++, Color = Color.Green },
                new { Source = CreateSource(), Ind = _ImageCount++, Color = Color.Gold },
                new { Source = CreateSource(), Ind = _ImageCount++, Color = Color.Silver },
                new { Source = CreateSource(), Ind = _ImageCount++, Color = Color.Blue }
            };

            PanPositionChangedCommand = new Command(v =>
            {
                if (IsAutoAnimationRunning || IsUserInteractionRunning)
                {
                    return;
                }

                var index = CurrentIndex + (bool.Parse(v.ToString()) ? 1 : -1);
                if (index < 0 || index >= Items.Count)
                {
                    return;
                }
                CurrentIndex = index;
            });

            RemoveCurrentItemCommand = new Command(() =>
            {
                if (!Items.Any())
                {
                    return;
                }
                Items.RemoveAt(CurrentIndex.ToCyclingIndex(Items.Count));
            });

            GoToLastCommand = new Command(() =>
            {
                CurrentIndex = Items.Count - 1;
            });

            initData();
        }

        public ICommand PanPositionChangedCommand { get; }

        public ICommand RemoveCurrentItemCommand { get; }

        public ICommand GoToLastCommand { get; }

        public int CurrentIndex
        {
            get => _currentIndex;
            set
            {
                _currentIndex = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentIndex)));
            }
        }

        public bool IsAutoAnimationRunning { get; set; }

        public bool IsUserInteractionRunning { get; set; }

        public ObservableCollection<object> Items { get; }

        private string CreateSource()
        {
            var source = $"https://picsum.photos/1000/500?image={_ImageCount}";
            return source;
        }

        private ObservableCollection<HomeNowListModel> myItemsPushCourse;
        public ObservableCollection<HomeNowListModel> MyItemsPushCourse
        {
            set
            {
                myItemsPushCourse = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MyItemsPushCourse)));
            }
            get { return myItemsPushCourse; }
        }

        public void initData() {
            getPushcourse();
        }


        /// <summary>
        /// 获取推荐课程
        /// </summary> 
        /// <returns></returns>
        public void getPushcourse()
        {

            var puntos = Services.HomeService.Instance.getPushcourse();
            if (puntos != null)
            {
                //TODO
                MyItemsPushCourse = new ObservableCollection<HomeNowListModel>();
                //TODO
                HomeNowModel tmp = JsonConvert.DeserializeObject<HomeNowModel>(puntos);

                foreach (HomeNowListModel typeStr in tmp.data)
                {
                    MyItemsPushCourse.Add(typeStr);
                }
            }
            else
            {

            }
        }
    }
}
