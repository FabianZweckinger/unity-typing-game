using UnityEngine;

public class SoundController : MonoBehaviour {

    [Header("Settings:")]
    [Range(0, 1)] public float tapSuccessVolume = 1;
    public AudioClip[] tapSuccessSounds;
    [Range(0, 1)] public float tapFailVolume = 1;
    public AudioClip[] tapFailSounds;


    public void PlayTapSuccessSound() {
        PlaySound(tapSuccessSounds, tapSuccessVolume);
    }

    public void PlayTapFailSound() {
        PlaySound(tapFailSounds, tapFailVolume);
    }

    private void PlaySound(AudioClip[] ac, float volume) {
        AudioSource.PlayClipAtPoint(ac[Random.Range(0, ac.Length)], Vector2.zero, volume);
    }
}
