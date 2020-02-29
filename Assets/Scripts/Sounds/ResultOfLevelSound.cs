using UnityEngine;

public class ResultOfLevelSound : MonoBehaviour
{
    public AudioClip VictoryClip;
    public AudioClip DefeatClip;

    public void PlayVictoryClip()
    {
        SFXManager.Instance.Play(VictoryClip, transform.position);
    }

    public void PlayDefeatClip()
    {
        SFXManager.Instance.Play(DefeatClip, transform.position);
    }
}
