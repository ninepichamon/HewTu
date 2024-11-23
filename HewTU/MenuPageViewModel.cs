using System.Collections.ObjectModel;

namespace HewTU
{
    // เปลี่ยนชื่อคลาสเป็น MenuPageViewModel
    public class MenuPageViewModel
    {
        // สร้าง property สำหรับเก็บรายการเมนู
        public ObservableCollection<MenuItemViewModel> MenuItems { get; set; }

        // ตัวสร้าง (Constructor) ที่จะถูกเรียกเมื่อสร้างคลาสนี้
        public MenuPageViewModel()
        {
            // สร้างรายการเมนูตัวอย่าง
            MenuItems = new ObservableCollection<MenuItemViewModel>
            {
                new MenuItemViewModel { Name = "Bubble Tea", Price = "$3.99", Image = "bubble_tea.jpg" },
                new MenuItemViewModel { Name = "Steak", Price = "$15.99", Image = "steak.jpg" },
                new MenuItemViewModel { Name = "Flower Bouquet", Price = "$25.00", Image = "flower_bouquet.jpg" },
                new MenuItemViewModel { Name = "Mala Hotpot", Price = "$10.50", Image = "mala_hotpot.jpg" }
            };
        }
    }

    // คลาส MenuItemViewModel สำหรับเก็บข้อมูลเมนู
    public class MenuItemViewModel
    {
        public string Name { get; set; }  // ชื่อเมนู
        public string Price { get; set; } // ราคาเมนู
        public string Image { get; set; } // ชื่อไฟล์รูปภาพ
    }
}
