using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace VisualListViewTest
{
    public class MainPageViewModel
    {
        private ObservableCollection<Pic> _items;

        public ObservableCollection<Pic> Items { get => _items; set => _items = value; }


        public MainPageViewModel()
        {
            SetData();
        }
        private async Task SetData()
        {
            _items = new ObservableCollection<Pic>();
            string root = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;
            string path = root + @"\Assets\timg.jpg";
            for (var i = 0; i < 1000; i++)
            {
                var tem = await getImageSource(path);
                Items.Add(new Pic { Name = "ss", source = tem});
            }
        }
        private async Task<ImageSource> getImageSource(string Path)
        {
            var file = await Windows.Storage.StorageFile.GetFileFromPathAsync(Path);
            var stream = await file.OpenReadAsync();
            var bitmapImage = new BitmapImage();
            await bitmapImage.SetSourceAsync(stream);
            return bitmapImage;
        }

    }
    public class Pic
    {
        public string Name { get; set; }
        public ImageSource source { get; set; }
    }
}
