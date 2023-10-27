using UnityEngine;
using UnityEngine.UI;
using System;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private Text text;
    [SerializeField] private InputField inputField;

    private int value = 0;

    private void Start()
    {
        value = UnityEngine.Random.Range(0, 11);
    }

    public void onCheckClick()
    {
        if(inputField.text.Equals(value.ToString()))
        {
            text.text = "Угадали";
        }
        else if(Convert.ToInt32(inputField.text)>value)
        {
            text.text = "Загаданное число меньше";
        }
        else if (Convert.ToInt32(inputField.text) < value)
        {
            text.text = "Загаданное число больше";
        }
    }
}
