using UnityEngine;
using UnityEngine.UI;
using System;

public class CompareScript : MonoBehaviour
{
    [SerializeField] private Text result;
    [SerializeField] private InputField firstInputField;
    [SerializeField] private InputField secondInputField;


    private void Start()
    {
        result.text = "";
    }

    private void checkInputFieldsValues()
    {
        firstInputField.text = replaceSign(firstInputField.text);
        secondInputField.text = replaceSign(secondInputField.text);
    }

    private string replaceSign(string value)
    {
        return (value.Replace('.', ','));
    }

    public void onCompareClick()
    {
        checkInputFieldsValues();
        switch(double.Parse(firstInputField.text).CompareTo(double.Parse(secondInputField.text)))
        {
            case -1:
                {
                    result.text = $"Значение: {firstInputField.text} меньше значения: {secondInputField.text}";
                    break;
                }
            case 0:
                {
                    result.text = $"Значение: {firstInputField.text} равно значению: {secondInputField.text}";
                    break;
                }
            case 1:
                {
                    result.text = $"Значение: {firstInputField.text} больше значения: {secondInputField.text}";
                    break;
                }
        }
    }
}
