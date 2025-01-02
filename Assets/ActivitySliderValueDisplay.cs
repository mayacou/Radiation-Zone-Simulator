using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ActivitySliderValueDisplay : MonoBehaviour
{
    public Slider activitySlider; // The slider for activity
    public TMP_Text valueText; // The text to display the slider value
    public TMP_InputField inputField; // The input field for manual entry

    private void Start()
    {
        // Initialize the value text and input field
        UpdateValueText(activitySlider.value);
        UpdateInputField(activitySlider.value);

        // Add listeners
        activitySlider.onValueChanged.AddListener(UpdateValueText);
        activitySlider.onValueChanged.AddListener(UpdateInputField);
        inputField.onValueChanged.AddListener(UpdateSliderFromInput);
    }

    private void UpdateValueText(float value)
    {
        // Update the text to show the current slider value
        valueText.text = value.ToString("F1"); // Display 1 decimal place
    }

    private void UpdateInputField(float value)
    {
        // Update the input field to show the current slider value
        inputField.text = value.ToString("F1");
    }

    private void UpdateSliderFromInput(string input)
    {
        // Parse the input field value and update the slider
        if (float.TryParse(input, out float value))
        {
            activitySlider.value = value;
        }
    }
}


