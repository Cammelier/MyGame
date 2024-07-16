using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{
    // Start is called before the first frame update
   public static audioManager instance;
    public AudioSource backgroundmusic, click, death, fly, gameover, record;

    private void Awake()
    {
        instance = this;
    }

    public void PlayClick()
    {
        click.Play();
    }
    
    public void Playdeath()
    {
        death.Play();   
    }
    public void PlayFly()
    {
        fly.Play();
    }
    public void PlayRecord()
    {
        record.Play();
    }

    public void Playgameover()
    {
        StartCoroutine(GameOverSound());    
    }

    public void StopGameMusic()
    {
        backgroundmusic.Stop(); 
    }

    IEnumerator GameOverSound()
    {
        yield return new WaitForSecondsRealtime(1.5f);
        gameover.Play();
    }
}
