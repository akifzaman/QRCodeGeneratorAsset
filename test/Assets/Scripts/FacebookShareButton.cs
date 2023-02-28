//using UnityEngine;
//using UnityEngine.UI;
//public class FacebookShareButton : MonoBehaviour
//{
//    public string shareUrl; // The URL to share on Facebook
//    public Texture2D imageToShare; // The image to share on Facebook

//    public void ShareOnFacebook()
//    {
//        // Check if the Facebook app is installed on the device
//        if (Application.platform == RuntimePlatform.Android)
//        {
//            bool facebookAppInstalled = NativeShare.IsPackageInstalled("com.facebook.katana");
//            if (facebookAppInstalled)
//            {
//                // Use the NativeShare plugin to share the image on Facebook
//                NativeShare share = new NativeShare();
//                share.SetSubject("Check out my image!");
//                share.SetText("I just shared this image on Facebook!");
//                share.SetUrl(shareUrl);
//                share.AddFile(imageToShare, "image.png");
//                share.Share();
//            }
//            else
//            {
//                // If the Facebook app is not installed, open the Facebook website in the device's web browser
//                Application.OpenURL("https://www.facebook.com/sharer/sharer.php?u=" + shareUrl);
//            }
//        }
//        else
//        {
//            // If the app is running on a platform other than Android, open the Facebook website in the device's web browser
//            Application.OpenURL("https://www.facebook.com/sharer/sharer.php?u=" + shareUrl);
//        }
//    }
//}