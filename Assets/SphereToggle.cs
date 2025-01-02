using UnityEngine;

public class SphereToggle : MonoBehaviour
{
    public GameObject radiationSphere; // The sphere itself
    public GameObject checkmark; // The checkmark to indicate sphere visibility

    private Renderer sphereRenderer;

    void Start()
    {
        // Get the Renderer component from the radiation sphere
        sphereRenderer = radiationSphere.GetComponent<Renderer>();
    }

    public void ToggleSphereVisibility()
    {
        // Toggle the sphere's renderer visibility
        bool isVisible = sphereRenderer.enabled;
        sphereRenderer.enabled = !isVisible; // Enable or disable the visual representation of the sphere

        // Show or hide the checkmark based on the sphere's visibility
        checkmark.SetActive(!isVisible);

        Debug.Log("Sphere visibility toggled: " + !isVisible);
    }
}

