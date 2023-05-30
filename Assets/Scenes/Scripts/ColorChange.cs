using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    [SerializeField] private Material Groundmaterial;
    public Color[] colors;
    public int colorindex = 0;
    [SerializeField] public float lerpvalue;
    [SerializeField] public float time;
    private float currenttime;
    private void Update()
    {
        SetColorTime();
        setColor();
        
    }
    private void SetColorTime()
    {
        if (currenttime <= 0)
        {
            CheckColorIndexValue();
            currenttime = time;
        }
        else
        {
            currenttime -= Time.deltaTime;
        }
    }
    private void CheckColorIndexValue()
    {
        colorindex++;
        if ( colorindex >= colors.Length)
        {
            colorindex = 0;
        }
    }
    private void setColor()
    {
        Groundmaterial.color = Color.Lerp(Groundmaterial.color, colors[colorindex], lerpvalue * Time.deltaTime);
    }
    private void OnDestroy()
    {
        Groundmaterial.color = colors[1];
    }
}
