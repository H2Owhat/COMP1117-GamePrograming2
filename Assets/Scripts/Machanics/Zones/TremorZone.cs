using Unity.Cinemachine;
using UnityEngine;

public class TremorZone : Zone
{
    private CinemachineImpulseSource impulseSource;

    void Awake()
    {
        impulseSource = GetComponent<CinemachineImpulseSource>();
    }
    protected override void ApplyZoneEffect(Player player)
    {
        PlayImpulse();
    }

    public void PlayImpulse()
    {
        if (impulseSource != null)
        {
            impulseSource.GenerateImpulse();
        }
    }
}
