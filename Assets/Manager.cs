using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using static System.Collections.Specialized.BitVector32;

public class Manager : MonoBehaviour
{
    public InputField written1Input; 
    public InputField written2Input;
    public InputField written3Input; 
    public InputField performance1Input;
    public InputField performance2Input; 
    public InputField quarterly1Input;
    public Text resultInputField; 

    public void Calculate()
    {
        float numA1, numA2, numA3, numB1, numB2, numC;

        if (float.TryParse(written1Input.text, out numA1) &&
            float.TryParse(written2Input.text, out numA2) &&
            float.TryParse(written3Input.text, out numA3) &&
            float.TryParse(performance1Input.text, out numB1) &&
            float.TryParse(performance2Input.text, out numB2) &&
            float.TryParse(quarterly1Input.text, out numC))
        {
            float avgA = (numA1 + numA2 + numA3) / 3f;
            float avgB = (numB1 + numB2) / 2f;

            float result = (avgA * 0.2f) + (avgB * 0.6f) + (numC * 0.2f);

            if (result > 100)
            {
                resultInputField.text = "Error: Result exceeds 100!";
            }
            else
            {
                resultInputField.text = result.ToString("F2"); // Show result with 2 decimal places
            }
        }
        else
        {
            resultInputField.text = "Invalid Input!";
        }
    }
}