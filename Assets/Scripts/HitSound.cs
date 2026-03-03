using UnityEngine;

public class HitSound : MonoBehaviour
{
    [SerializeField] private AudioClip _clip;
    private AudioSource _source;

    private void Start()
    {
        _source = GetComponent<AudioSource>();
    }

    public void OnSound() => _source.PlayOneShot(_clip);
}