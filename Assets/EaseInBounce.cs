using UnityEngine;
using DG.Tweening;


public class EaseInBounce : MonoBehaviour
{
    public void WrongBounce()
    {
        transform.DOShakePosition(0.8f, 20, 30);
    }
}