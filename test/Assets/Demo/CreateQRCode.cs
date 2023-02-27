using UnityEngine;  
using System.Collections;  
using ZXing; 
using ZXing.QrCode;  
using UnityEngine.UI;  
using TMPro;
using System.Collections.Generic;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class CreateQRCode : MonoBehaviour  
{   
	public Texture2D encoded;  
	public string Lastresult;
    public Image QRCodePlaceHolder;

    public List<TMP_InputField> inputFields;

    public GameObject Form;
    public Button GenerateButton;

    public CanvasGroup QRCodeImageCanvas;
    public CanvasGroup ShareButtonCanvasGroup;
    public CanvasGroup GenerateAgainButtonCanvas;

    public Scene scene;
    // For generating raw text
    public virtual string GenerateText()
    {
        return Lastresult;
    }

    // For generating QRCode
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

	// For generating the QRCode Image
    public void GenerateQROutput()
    {
        encoded = new Texture2D(256, 256);
        var textForEncoding = Lastresult;
        if (textForEncoding != null)
        {
            var color32 = Encode(textForEncoding, encoded.width, encoded.height);
            encoded.SetPixels32(color32);
            encoded.Apply();
        }
        QRCodePlaceHolder.sprite = Sprite.Create(encoded, new Rect(0, 0, encoded.width, encoded.height), Vector2.zero);
    }

    public void GenerateAgain()
    {
        scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
    public void StoreInput()
    {
        GenerateButton.gameObject.SetActive(false);
        UIManager.Instance.FadeIn(QRCodeImageCanvas);
        UIManager.Instance.FadeIn(ShareButtonCanvasGroup);
        UIManager.Instance.FadeIn(GenerateAgainButtonCanvas);
    }
}  