using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PhotoGallery
{
    class DisplayPhotoData
    {
        static void Main(string[] args)
        {
            int numberOfPhoto = int.Parse(Console.ReadLine());
            int dayOfPhoto = int.Parse(Console.ReadLine());
            int monthOfPhoto = int.Parse(Console.ReadLine());
            int yearOfPhoto = int.Parse(Console.ReadLine());
            int hourOfPhoto = int.Parse(Console.ReadLine());
            int minuteOfPhoto = int.Parse(Console.ReadLine());
            int sizeOfPhotoBytes = int.Parse(Console.ReadLine());
            int widthOfPhoto = int.Parse(Console.ReadLine());
            int heightOfPhoto = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: DSC_{numberOfPhoto:D4}.jpg");
            Console.WriteLine($"Date Taken: {dayOfPhoto:D2}/{monthOfPhoto:D2}/{yearOfPhoto} {hourOfPhoto:D2}:{minuteOfPhoto:D2}");
            if (sizeOfPhotoBytes<1000)
            {
                Console.WriteLine($"Size: {sizeOfPhotoBytes}B");
            }
            else if (sizeOfPhotoBytes>=1000 && sizeOfPhotoBytes<= 1000000)
            {
                Console.WriteLine($"Size: {sizeOfPhotoBytes/1000}KB");
            }
            else
            {
                Console.WriteLine($"Size: {sizeOfPhotoBytes/1000000.0}MB");
            }
            if (widthOfPhoto>heightOfPhoto)
            {
                Console.WriteLine($"Resolution: {widthOfPhoto}x{heightOfPhoto} (landscape)");
            }
            else if (widthOfPhoto<heightOfPhoto)
            {
                Console.WriteLine($"Resolution: {widthOfPhoto}x{heightOfPhoto} (portrait)");
            }
            else
            {
                Console.WriteLine($"Resolution: {widthOfPhoto}x{heightOfPhoto} (square)");
            }
        }
    }
}
