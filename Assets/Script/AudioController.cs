using UnityEngine;

public class AudioController : MonoSingleton<AudioController>
{
    public AudioSource Musiche;
    public AudioClip[] musiclips;
    public AudioSource Effect;
    public AudioClip[] effectclips; 

    private int indiceclip = 0;

    void Start()
    {
        if (Musiche == null)
        {
            Musiche = GetComponent<AudioSource>();
        }
    }

    void Update()
    {

        if (!Musiche.isPlaying)
        {
            //PlayNextClip();
        }
    }

    //void PlayNextClip()
    //{
    //    if (musiclips.Length == 0)
    //        return;


    //    Musiche.clip = musiclips[indiceclip];
    //    Musiche.Play();

  
    //    indiceclip = (indiceclip + 1) % musiclips.Length;
    //}
}
