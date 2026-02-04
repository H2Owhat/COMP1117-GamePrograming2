using UnityEngine;

public class WaterZone : Zone
{
    [SerializeField] private float speedModifier = 0.5f;
    protected override void ApplyZoneEffect(Player player)
    {
        //change player speed modifier value 
        player.ApplySpeedModifier(speedModifier);
    }
}
