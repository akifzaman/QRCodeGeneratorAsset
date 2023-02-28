//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using DG.Tweening;
//using UnityEngine.UI;
//using TMPro;
//public class InputFieldController : MonoBehaviour
//{
//    public List<TMP_InputField> inputFields;
//    public List<RectTransform> inputFieldTransforms;
//    public RectTransform PanelRectTransform;
//    public float moveDuration = 1f;
//    public float delayBetweenMoves = 0.5f;
//    public float finalXPosition = 1640f;
//    public float finalYPosition = -2000f;

//    public CanvasGroup ButtonCanvas;
    
//    private void Start()
//    {
//        ShowForm();
//    }

//    public void ShowForm()
//    {
//        foreach (var inputFieldTransform in inputFieldTransforms)
//        {
//            MoveInputFieldX(inputFieldTransform, finalXPosition);
//        }
//    }
//    IEnumerator ShowShareButtons()
//    {
//        yield return new WaitForSeconds(1f);
//    }
//    public void RemoveForm()
//    {
//        foreach (var inputFieldTransform in inputFieldTransforms)
//        {
//            MoveInputFieldX(inputFieldTransform, 2 * finalXPosition);
//        }
//    }
//    private void MoveInputFieldX(RectTransform inputFieldTransform, float xPosition)
//    {
//        inputFieldTransform.DOAnchorPosX(xPosition, moveDuration).SetDelay(delayBetweenMoves);
//    }
//}