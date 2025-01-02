using UnityEngine;

public class RadiationZoneTrigger : MonoBehaviour
{
    public GameObject redHazePanel; // The red screen overlay
    public TMPro.TextMeshProUGUI radiationAlertText; // The warning text
    public Renderer sphereRenderer; // Renderer for the sphere

    private bool isPlayerInside = false; // Track if the player is inside the sphere

    private void Start()
    {
        // Ensure sphereRenderer is assigned
        if (sphereRenderer == null)
        {
            sphereRenderer = GetComponent<Renderer>();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Main Camera")
        {
            Debug.Log("Player entered the radiation zone.");
            isPlayerInside = true;

            // Always show the warning
            radiationAlertText.text = "WARNING: \nYou are inside the radiation zone!";

            // Only show the red haze if the sphere is visible
            if (sphereRenderer.enabled)
            {
                redHazePanel.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Main Camera")
        {
            Debug.Log("Player exited the radiation zone.");
            isPlayerInside = false;

            // Always hide the warning
            radiationAlertText.text = "";

            // Always hide the red haze
            redHazePanel.SetActive(false);
        }
    }

    private void Update()
    {
        // If the sphere is toggled visible and the player is inside, ensure the red haze is shown
        if (isPlayerInside && sphereRenderer.enabled && !redHazePanel.activeSelf)
        {
            redHazePanel.SetActive(true);
            Debug.Log("Red haze activated because sphere visibility was toggled back on.");
        }

        // Safety check: If the sphere is toggled off while the player is inside, ensure the red haze is hidden
        if (!sphereRenderer.enabled && redHazePanel.activeSelf)
        {
            redHazePanel.SetActive(false);
        }
    }
}









