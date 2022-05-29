using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
  [SerializeField] private AudioSource AudioSource;

  public void OnClickPlay()
  {
    // オーディオを再生します
    AudioSource.Play();
  }

  public void OnClickPause()
  {
    // オーディオを一時停止します
    AudioSource.Pause();
  }

  public void OnClickStop()
  {
    // オーディオを停止します
    AudioSource.Stop();
  }
}
