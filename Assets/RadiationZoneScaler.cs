using UnityEngine;

public class RadiationZoneScaler : MonoBehaviour
{
    public RadiationZoneCalculator.IsotopeType isotopeType;
    public float activity = 1000000.0f; // Default activity value

    void Update()
    {
        // Dynamically calculate radius
        float radius = RadiationZoneCalculator.CalculateRadius(isotopeType, activity);

        // Scale the sphere
        transform.localScale = new Vector3(radius, radius, radius);
    }

    // Method to set the isotope type from dropdown
    public void SetIsotopeType(int isotopeIndex)
    {
        // Convert the integer index to the IsotopeType enum
        isotopeType = (RadiationZoneCalculator.IsotopeType)isotopeIndex;
    }
    public void SetActivity(float newActivity)
    {
        activity = newActivity;
        Debug.Log("Activity updated to: " + activity); // For debugging
    }
}


