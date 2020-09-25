using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VRGaze : MonoBehaviour
{
    public Image imgGaze;
    public Text RedBox;
    public Text BlackBox;
    public float totalTime = 2;
    bool gvrStatus;
    float gvrTimer;
    // Start is called before the first frame update
    void Start()
    {
        RedBox.enabled = false;
        BlackBox.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gvrStatus)
        {
            gvrTimer += Time.deltaTime;
            imgGaze.fillAmount = gvrTimer / totalTime;
        }
    }

    public void GVROn()
    {
        gvrStatus = true;
    }

    public void GVROff()
    {
        gvrStatus = false;
        gvrTimer = 0;
        imgGaze.fillAmount = 0;
    }

    public void mouseoverRedBoxOn()
    {
        RedBox.enabled = true;
    }

    public void mouseoverRedBoxOff()
    {
        RedBox.enabled = false;
    }

    public void mouseoverBlackBoxOn()
    {
        BlackBox.enabled = true;
    }

    public void mouseoverBlackBoxOff()
    {
        BlackBox.enabled = false;
    }
}
