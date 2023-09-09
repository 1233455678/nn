using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class voulm : MonoBehaviour
{
    public AudioSource animationAudio;
    public Slider slider;
    bool isPlaying;

    void Start()
{
    animationAudio.Play();
    isPlaying = true;
}

void Update()
{
    if (isPlaying)
    {
        slider.value = animationAudio.time / animationAudio.clip.length;
    }
    print((int)animationAudio.time);
}

public void SliderDown()
{
    animationAudio.Pause();
    isPlaying = false;
}

public void SliderUp()
{
    if (slider.value * 100 <= animationAudio.clip.length)
    {
        if (!animationAudio.isPlaying && !isPlaying)
        {
            animationAudio.time = Mathf.Clamp(slider.value * animationAudio.clip.length, 0f, animationAudio.clip.length);
            animationAudio.UnPause();
            isPlaying = true;
        }
    }
    else
    {
        animationAudio.Stop();
        slider.value = animationAudio.time;

    }
}
}