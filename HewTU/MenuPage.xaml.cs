using System;
using System.Collections.ObjectModel;
using HewTU.DescriptionMenu;
using Microsoft.Maui.Controls;

namespace HewTU
{
    public partial class MenuPage : ContentPage
    {
        public ObservableCollection<MenuItemModel> MenuItems { get; set; }
        public Command<MenuItemModel> NavigateToDetailsCommand { get; }

        public MenuPage() // คอนสตรัคเตอร์ของ MenuPage
        {
            InitializeComponent();

            // ตัวอย่างรายการเมนู
            MenuItems = new ObservableCollection<MenuItemModel>
            {
                new MenuItemModel { Name = "Thai Tea", Price = "55 Baht", Image = "thaitea.png", DetailsPage = typeof(Thaitea) }
            };

            // ตั้งค่าคำสั่ง Navigation
            NavigateToDetailsCommand = new Command<MenuItemModel>(OnNavigateToDetails);

            BindingContext = this;
        }

        // คำสั่งที่ถูกเรียกเมื่อกดรายการเมนู
        private async void OnNavigateToDetails(MenuItemModel item)
        {
            if (item.DetailsPage != null)
            {
                var page = (Page)Activator.CreateInstance(item.DetailsPage);
                await Navigation.PushAsync(page); // นำทางไปยังหน้าเมนูที่กำหนด
            }
        }
    }

    // แก้ชื่อคลาสเป็น MenuItemModel สำหรับข้อมูลเมนู
    public class MenuItemModel
    {
        public string Name { get; set; }  // ชื่อเมนู
        public string Price { get; set; } // ราคาเมนู
        public string Image { get; set; } // ชื่อไฟล์รูปภาพ

        public Type DetailsPage { get; set; }
        
    }
}