using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI _Points;
    private int _points = 0;

    void Start()
    {
        _Points.text = "Points: " + _points;
    }


    public void UpdatePoints()
    {
        _points++;
        _Points.text = "Points: " + _points;
    }



}
