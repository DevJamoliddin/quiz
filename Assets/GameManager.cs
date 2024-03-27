using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _level1;
    [SerializeField] private GameObject _level2;
    [SerializeField] private GameObject _level3;

    void Start()
    {
        _level1.SetActive(true);
        _level2.SetActive(false);
        _level3.SetActive(false);
    }

    public void GoToLevel(int level)
    {
        if (level == 1)
        {
            _level1.SetActive(true);
            _level2.SetActive(false);
            _level3.SetActive(false);
        } else if (level == 2)
        {
            _level1.SetActive(false);
            _level2.SetActive(true);
            _level3.SetActive(false);
        } else if (level == 3)
        {
            _level1.SetActive(false);
            _level2.SetActive(false);
            _level3.SetActive(true);
        }

    }
}
