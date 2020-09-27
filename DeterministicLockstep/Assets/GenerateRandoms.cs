// Imports
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Class GenerateRandoms, to generate random numbers
/// </summary>
public class GenerateRandoms : MonoBehaviour
{
    #region Variables

    #region Public Variables
    [Header("Parameters")]
    [Tooltip("Seed to randomize")]
    public int randomSeed = 0;
    [Tooltip("Quantity of generated numbers")]
    public int numbersToGenerate = 10;
    [Tooltip("Time until the next number")]
    public float timeBetweetNumbers = 0.5f;
    #endregion

    #region Private Variables
    // Instance of the Random class from System
    private System.Random randomGenerator;
    // Text to update
    private Text numbersText;
    #endregion

    #endregion

    #region Methods

    /// <summary>
    ///  Method Start, that executes before the first frame
    /// </summary>
    private void Start()
    {
        // Put the seed on the random generator
        randomGenerator = new System.Random(randomSeed);

        // Get the text component and erase its content
        numbersText = GetComponent<Text>();
        numbersText.text = "";

        // Generate random numbers
        for (int i = 0; i < numbersToGenerate; i++)
        {
            Invoke("AddRandomNumber", (i+1) * timeBetweetNumbers);
        }
    }

    /// <summary>
    /// Method AddRandomNumber, that generates a random and add it to the text
    /// </summary>
    private void AddRandomNumber()
    {
        // Generate the random number and add it to the text
        int randomNumber = randomGenerator.Next(10);
        numbersText.text += randomNumber + ", ";
    }

    #endregion
}
