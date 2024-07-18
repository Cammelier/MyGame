using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{
    // Start is called before the first frame update
   public static audioManager instance;
    public AudioSource backgroundmusic, click, death, fly, record;

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

    

    public void StopGameMusic()
    {
        backgroundmusic.Stop(); 
    }

   
}
