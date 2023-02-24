using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactInfo
{
    public string Name { get; }
    public string Company { get; }
    public string Title { get; }
    public string PhoneNumber { get; }
    public string Email { get; }
    public string Address { get; }
    public string Address2 { get; }
    public string Website { get; }

    public ContactInfo(string name, string company, string title, string phoneNumber, string email, string address, string address2, string website)
    {
        Name = name;
        Company = company;
        Title = title;
        PhoneNumber = phoneNumber;
        Email = email;
        Address = address;
        Address2 = address2;
        Website = website;
    }
}

/*
 * using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class UIManager : MonoBehaviour
{
    public float fadeTime = 1f;
    public CanvasGroup canvasGroup;
    public CanvasGroup ButtonCanvasGroup;
    public RectTransform rectTransform;
    public List<GameObject> items = new List<GameObject>();
    public void PanelFadeOut()
    {
        canvasGroup.alpha = 1f;
        ButtonCanvasGroup.alpha = 1f;
        rectTransform.transform.localPosition = new Vector3(0f, 0f, 0f);
        rectTransform.DOAnchorPos(new Vector2(1640f, -1000f), fadeTime, false).SetEase(Ease.InOutQuint);
        canvasGroup.DOFade(0, fadeTime);
        ButtonCanvasGroup.DOFade(0, fadeTime);
    }

    IEnumerator ItemsAnimation()
    {
        yield return new WaitForSeconds(0.5f);
        ButtonCanvasGroup.DOFade(1, fadeTime);
        foreach (var item in items)
        {
            item.transform.localScale = Vector3.zero;
        }

        foreach (var item in items)
        {
            item.transform.DOScale(1f, fadeTime).SetEase(Ease.OutBounce);
            yield return new WaitForSeconds(0.25f);
        }
    }
} */