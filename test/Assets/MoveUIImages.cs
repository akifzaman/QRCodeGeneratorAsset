//using UnityEngine;
//using UnityEngine.UI;
//using DG.Tweening;
//using TMPro;

//public class MoveUIImages : MonoBehaviour
//{
//    public TMP_InputField[] imagesToMove;  // An array of the UI images to move
//    public float moveDuration;    // The duration of the move animation
//    public float delayBetweenMoves; // The delay between each image's move animation

//    private VerticalLayoutGroup layoutGroup; // Reference to the VerticalLayoutGroup component

//    void Start()
//    {
//        // Get a reference to the VerticalLayoutGroup component on this game object
//        layoutGroup = GetComponent<VerticalLayoutGroup>();

//        // Move each image one by one with a delay between each one
//        for (int i = 0; i < imagesToMove.Length; i++)
//        {
//            // Calculate the target position for this image to move to (center of the screen)
//            Vector3 targetPosition = new Vector3(Screen.width / 2f, imagesToMove[i].position.y, 0f);

//            // Move the image using DoTween's DOMove method
//            imagesToMove[i].DOMove(targetPosition, moveDuration).SetDelay(i * delayBetweenMoves);

//            // Once the final image has been moved, activate the VerticalLayoutGroup
//            if (i == imagesToMove.Length - 1)
//            {
//                // Use DoTween's OnComplete method to execute a callback function once the move animation has finished
//                imagesToMove[i].DOMove(targetPosition, moveDuration).SetDelay(i * delayBetweenMoves).OnComplete(ActivateVerticalLayoutGroup);
//            }
//        }
//    }

//    // Activate the VerticalLayoutGroup component once all of the images have finished moving
//    void ActivateVerticalLayoutGroup()
//    {
//        layoutGroup.enabled = true;
//    }
//}
