using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using XamarinAppLib.Models;

namespace XamarinAppLib.ViewModels
{
    public class HomeViewModel :INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public HomeViewModel() {
            initData();
        }

        public void initData()
        {
            getPushcourse();
        }

        public void getPushcourse()
        {

            MyItemsPushCourse = new ObservableCollection<HomeNowListModel>();

            var model = new HomeNowModel();
            model.code = "200";
            model.msg = "success";
            model.data = new HomeNowListModel[4];

            model.data[0] = new HomeNowListModel();
            model.data[0].id = 1;
            model.data[0].name = "测试前端组设计功能账号1";
            model.data[0].teacher_name = "测试name1";
            model.data[0].ytime = "1h";
            model.data[0].image = "https://picsum.photos/id/12/1000/500";
            model.data[0].avatar = "https://picsum.photos/id/1/1000/500";



            model.data[1] = new HomeNowListModel();
            model.data[1].id = 2;
            model.data[1].name = "测试账号开发部测试测试流程2";
            model.data[1].teacher_name = "测试name2";
            model.data[1].ytime = "1h";
            model.data[1].image = "https://picsum.photos/id/13/1000/500";
            model.data[1].avatar = "https://picsum.photos/id/2/1000/500";


            model.data[2] = new HomeNowListModel();
            model.data[2].id = 3;
            model.data[2].name = "测试设计组测试测试流程账号3";
            model.data[2].teacher_name = "测试name3";
            model.data[2].ytime = "1h";
            model.data[2].image = "https://picsum.photos/id/13/1000/500";
            model.data[2].avatar = "https://picsum.photos/id/2/1000/500";



            model.data[3] = new HomeNowListModel();
            model.data[3].id = 4;
            model.data[3].name = "测试账号4";
            model.data[3].teacher_name = "测试name4";
            model.data[3].ytime = "1h";
            model.data[3].image = "https://picsum.photos/id/14/1000/500";
            model.data[3].avatar = "https://picsum.photos/id/3/1000/500";

            MyItemsPushCourse.Add(model.data[0]);
            MyItemsPushCourse.Add(model.data[1]);
            MyItemsPushCourse.Add(model.data[2]);
            MyItemsPushCourse.Add(model.data[3]);
            //TODO
            //JsonConvert.SerializeObject(model);
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

    }
}
