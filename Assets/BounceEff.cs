using UnityEngine;
using DG.Tweening;


public class BounceEff : MonoBehaviour
{
    public static bool needToBounce = false;
    private bool _isBouncing = false;

    void Start()
    {
        BounceObj();
    }

    private void Update()
    {
        if (needToBounce)
        {
            if (!_isBouncing)
            {
                BounceObj();
                DOVirtual.DelayedCall(1f, () => {
                    needToBounce = false;
                });
            }
        }
    }

    public void BounceObj()
    {
        _isBouncing = true;
        DOVirtual.DelayedCall(1.2f, () => {
            _isBouncing = false;
        });
        DOTween.Sequence()
        .Append(transform.DOScale(endValue: 1.5f, duration: 0.4f))
        .Append(transform.DOScale(endValue: 0.5f, duration: 0.4f))
        .Append(transform.DOScale(endValue: 1, duration: 0.4f));
    }
}