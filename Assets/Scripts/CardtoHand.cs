using UnityEngine;

public class CardtoHand : MonoBehaviour
{
    public GameObject Hand;
    public GameObject HandCard;
    void Start()
    {
        // Find the Hand in the scene
        GameObject hand = GameObject.Find("Hand");

        if (hand != null)
        {
            // Set parent to the hand
            transform.SetParent(hand.transform);
            
            // Reset local scale and apply table/hand rotation and position
            transform.localScale = new Vector3(7f, 7f, 7f);
            transform.localPosition = Vector3.zero; // Or offset based on card index later
            transform.localRotation = Quaternion.Euler(25, 0, 0);
        }
    }
}