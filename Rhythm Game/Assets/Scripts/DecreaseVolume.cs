using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class DecreaseVolume : MonoBehaviour
{
    public TextMeshProUGUI volume;
    private bool isTouching;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && isTouching == false)
        {
            isTouching = true;
            if (int.Parse(volume.text) > 0)
            {
                volume.text = (int.Parse(volume.text) - 5).ToString();

            }

        }
        if (Input.touchCount == 0)
        {
            isTouching = false;
        }
    }
}
