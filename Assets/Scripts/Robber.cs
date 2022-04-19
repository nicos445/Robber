using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robber : MonoBehaviour
{
    [SerializeField] private Transform bag;

    private Vector3 scaleAtStart;
    private int nbDiamonds = 0;

    void Start()
    {
        scaleAtStart = bag.localScale;
    }

    public void IncreaseOrDecreaseBag(bool increase)
    {
        if (increase)
        {
            nbDiamonds++;
        }
        else
        {
            nbDiamonds /= 2;
        }
        bag.localScale = scaleAtStart * (1 + nbDiamonds * 0.05f);
    }

}
