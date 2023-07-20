using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AptitudesUI : MonoBehaviour
{
    public Image[] aptitudes;
    public Sprite squareApt;
    public Sprite squareAptOff;
    public Sprite circleApt;
    public Sprite circleAptOff;
    public Sprite triangleApt;
    public Sprite triangleAptOff;

    public void SquareAptUIOff() 
    {
        aptitudes[0].sprite = squareAptOff;
    }

    public void SquareAptUIOn()
    {
        aptitudes[0].sprite = squareApt;
    }
}