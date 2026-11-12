using UnityEngine;
using TMPro; // Required for TextMeshPro

public class RandomNumberGenerator : MonoBehaviour
{
    [Header("UI Reference")]
    public TextMeshProUGUI numberDisplayText;

    void Start()
    {
        // Automatically generate a number when the game starts
        GenerateRandomNumber();
    }


    public void GenerateRandomNumber()
    {
        // Note: With integers, Random.Range(min, max) is exclusive of the max value.
        // Using (1, 51) guarantees numbers from 1 through 50.
        int randomNumber = Random.Range(1, 51);

        // Update the UI text on screen
        if (numberDisplayText != null)
        {
            numberDisplayText.text = "Number: " + randomNumber.ToString();
        }
    }
}