using System.Collections.Generic;
using UnityEngine;

public class OutfitChanger : MonoBehaviour
{
    [Header("Sprite To Change")]
    public SpriteRenderer bodyPart;

    [Header("Sprites to Cycle Through")]
    public List<Sprite> options = new List<Sprite>();

    private int _currentOption = 0;

    public void NextOption()
    {
        _currentOption++;

        if(_currentOption >= options.Count)
        {
            _currentOption = 0;
        }

        bodyPart.sprite = options[_currentOption];
    }

    public void PreviousOption()
    {
        _currentOption--;

        if(_currentOption <= 0)
        {
            _currentOption = options.Count - 1;
        }

        bodyPart.sprite = options[_currentOption];
    }
}
