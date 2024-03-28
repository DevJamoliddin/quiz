using DG.Tweening;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _level1;
    [SerializeField] private GameObject _level2;
    [SerializeField] private GameObject _level3;
    [SerializeField] private GameObject _restartPanel;

    [SerializeField] private ParticleSystem _particleSystem1, _particleSystem2, _particleSystem3;

    void Start()
    {
        _restartPanel.SetActive(false);
        _level1.SetActive(true);
        _level2.SetActive(false);
        _level3.SetActive(false);
    }

    public void GoToLevel(int level)
    {
        if (level == 1)
        {
            BounceEff.needToBounce = true;
            _restartPanel.SetActive(false);
            _level1.SetActive(true);
            _level2.SetActive(false);
            _level3.SetActive(false);
        }

        DOVirtual.DelayedCall(1.5f, () => {
            if (level == 2)
            {
                BounceEff.needToBounce = true;
                _level1.SetActive(false);
                _level2.SetActive(true);
                _level3.SetActive(false);
            }
            else if (level == 3)
            {
                BounceEff.needToBounce = true;
                _level1.SetActive(false);
                _level2.SetActive(false);
                _level3.SetActive(true);
            }
        });
    }

    public void RestartGamePanel()
    {
        DOVirtual.DelayedCall(1.5f, () => {
            _restartPanel.SetActive(true);
        });
        
    }

    public void EmitParticleLevel(int level)
    {
        if (level == 1)
        {
            _particleSystem1.Play();
        } else if (level == 2)
        {
            _particleSystem2.Play();
        } else if (level == 3)
        {
            _particleSystem3.Play();
        }
    }
}