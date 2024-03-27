using UnityEngine;
using DG.Tweening;


public class BounceEff : MonoBehaviour
{
    void Start()
    {
        BounceObj();
    }

    public void BounceObj()
    {
        DOTween.Sequence()
        .Append(transform.DOScale(endValue: 1.5f, duration: 0.4f))
        .Append(transform.DOScale(endValue: 0.5f, duration: 0.4f))
        .Append(transform.DOScale(endValue: 1, duration: 0.4f));
    }
}