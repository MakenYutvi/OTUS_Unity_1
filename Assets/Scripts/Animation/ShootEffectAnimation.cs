using UnityEngine;

public class ShootEffectAnimation : MonoBehaviour
{
    public ParticleSystem Effect;

    public void PlayEffect()
    {
        Effect.Play();
    }
}
