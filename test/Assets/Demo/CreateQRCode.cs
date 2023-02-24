using UnityEngine;  
using System.Collections;  
using ZXing; 
using ZXing.QrCode;  
using UnityEngine.UI;  
using TMPro;
public class CreateQRCode : MonoBehaviour  
{   
	public Texture2D encoded;  
	public string Lastresult;  

	//public RawImage ima; 
    public Image QRCodePlaceHolder;

    public Button GenerateButton;
    public TMP_InputField inputField;
    public string inputText;

    ContactInfo newContactInfo = new("a", "b", "c", "d", "e", "f", "g", "h");
	public void Start()  
	{  
		encoded = new Texture2D(256, 256);  
		//Lastresult = "http://www.google.com/ncr";  
        Lastresult = inputText;
		var textForEncoding = Lastresult;  
		if (textForEncoding != null)  
		{  
			var color32 = Encode(textForEncoding, encoded.width, encoded.height);  
			encoded.SetPixels32(color32);  
			encoded.Apply();  

			//ima.texture = encoded;  
		}
        QRCodePlaceHolder.sprite = Sprite.Create(encoded, new Rect(0, 0, encoded.width, encoded.height), Vector2.zero);
    }

    // for generate qrcode
	public static Color32[] Encode(string textForEncoding, int width, int height)  
	{  
		var writer = new BarcodeWriter  
		{  
			Format = BarcodeFormat.QR_CODE,  
			Options = new QrCodeEncodingOptions  
			{  
				Height = height,  
				Width = width  
			}  
		};  
		return writer.Write(textForEncoding);  
	}

    public void StoreInput()
    {
        QRCodePlaceHolder.gameObject.SetActive(true);
        inputText = inputField.text;
		Debug.Log(inputText);
    }
  //  public void ShowInfo()
  //  {
		//QRCodePlaceHolder.gameObject.SetActive(true);
		//Debug.Log(newContactInfo.Name);
  //  }
}  