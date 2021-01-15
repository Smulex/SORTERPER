using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace SortePerUI
{
    static class CardDal
    {
        public static ImageSource GetimageSource(string imageName)
        {
            BitmapImage source;
            try
            {
                source = new BitmapImage(new Uri(@"\Assets\" + imageName + ".png", UriKind.Relative));
            }
            catch (Exception)
            {
                source = new BitmapImage(new Uri(@"\Assets\Error.png", UriKind.Relative));
            }
            return source;
        }
    }
}
