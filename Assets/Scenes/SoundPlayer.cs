using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
  [SerializeField] private AudioSource AudioSource;

  public void OnClickPlay()
  {
    // �I�[�f�B�I���Đ����܂�
    AudioSource.Play();
  }

  public void OnClickPause()
  {
    // �I�[�f�B�I���ꎞ��~���܂�
    AudioSource.Pause();
  }

  public void OnClickStop()
  {
    // �I�[�f�B�I���~���܂�
    AudioSource.Stop();
  }
}
