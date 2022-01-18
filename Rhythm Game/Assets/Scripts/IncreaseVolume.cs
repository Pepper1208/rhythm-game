using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class IncreaseVolume : MonoBehaviour
{
    public TextMeshProUGUI volume;
    public bool isTouching;
    public int volumeNum;
    public bool isMaxVolume;
    // Update is called once per frame
    void Update()
    {
        volumeNum = int.Parse(volume.text);
        if (Input.touchCount > 0 && isTouching == false)
        {
            isTouching = true;
            if(volumeNum < 100)
            {
                isMaxVolume = false;

            }
            if (volumeNum == 100)
            {
                isMaxVolume = true;

            }
            if (isMaxVolume == false)
            {
                volume.text = (volumeNum + 5).ToString(); 
            }
            
        }
        if(Input.touchCount == 0)
        {
            isTouching = false;
        }
    }
}
