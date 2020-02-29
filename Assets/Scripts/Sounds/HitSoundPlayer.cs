using UnityEngine;

public class HitSoundPlayer : MonoBehaviour
{
    public AudioClip HitClip;
    public AudioClip ShootHitClip;
    public AudioClip HandHitClip;
    public AudioClip TakeDamageShortClip;
    public AudioClip TakeDamageLongClip;
    public AudioClip DeathClip;

    public void PlayHitClip()
    {
        SFXManager.Instance.Play(HitClip, transform.position);
    }
    public void PlayShootHitClip()
    {
        SFXManager.Instance.Play(ShootHitClip, transform.position);
    }
    public void PlayHandHitClip()
    {
        SFXManager.Instance.Play(HandHitClip, transform.position);
    }
    public void PlayTakeDamageShortClip()
    {
        SFXManager.Instance.Play(TakeDamageShortClip, transform.position);
    }
      public void PlayDeathClip()
    {
        SFXManager.Instance.Play(DeathClip, transform.position);
    }

}
