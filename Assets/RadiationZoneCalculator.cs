using UnityEngine;

public class RadiationZoneCalculator : MonoBehaviour
{
    public enum IsotopeType { Uranium234, Uranium235, Uranium238 }

    // Constants for energy per decay (in joules)
    private const float EnergyPerDecay_Uranium234 = 7.781715e-13f;
    private const float EnergyPerDecay_Uranium235 = 7.494156e-13f;
    private const float EnergyPerDecay_Uranium238 = 6.8403798e-13f;
    private const float SafetyThreshold = 1e-8f;

    // Method to calculate the radius of the radiation zone
    public static float CalculateRadius(IsotopeType isotope, float activity)
    {
        float energyPerDecay = isotope switch
        {
            IsotopeType.Uranium234 => EnergyPerDecay_Uranium234,
            IsotopeType.Uranium235 => EnergyPerDecay_Uranium235,
            IsotopeType.Uranium238 => EnergyPerDecay_Uranium238,
            _ => 0f
        };

        return Mathf.Sqrt((activity * energyPerDecay) / (4f * Mathf.PI * SafetyThreshold));
    }
}

