using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSettings : MonoBehaviour
{
    [SerializeField] Slider VolumeSlider;
    public void setvolume()
    {
        AudioListener.volume = VolumeSlider.value;
    }
}
