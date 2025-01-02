using UnityEngine;

public class MenuToggle : MonoBehaviour
{
    public GameObject sphereSettingsPanel; // Assign the SphereSettingsPanel here

    public void ToggleMenu()
    {
        // Toggle the menu's visibility
        bool isActive = sphereSettingsPanel.activeSelf;
        sphereSettingsPanel.SetActive(!isActive);

        Debug.Log("Sphere menu toggled: " + !isActive);
    }
}
