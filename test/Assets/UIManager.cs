using System.Collections;
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
}