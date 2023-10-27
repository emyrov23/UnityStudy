using UnityEngine;
using UnityEngine.UI;
using System;

public class CalcSript : MonoBehaviour
{
    [SerializeField] private Text result;
    [SerializeField] private InputField firstInputField;
    [SerializeField] private InputField secondInputField;


    private void Start()
    {
        //result.text = "";
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

    public void onAdd()
    {
        checkInputFieldsValues();
        if ((firstInputField.text != null) && (secondInputField.text != null))
        if((double.TryParse(firstInputField.text, out double resultFirst) &&(double.TryParse(secondInputField.text, out double resultSecond))))
        {
                result.text = (resultFirst + resultSecond).ToString();
        }
    }

    public void onMinus()
    {
        checkInputFieldsValues();
        if ((firstInputField.text != null) && (secondInputField.text != null))
            if ((double.TryParse(firstInputField.text, out double resultFirst) && (double.TryParse(secondInputField.text, out double resultSecond))))
            {
                result.text = (resultFirst - resultSecond).ToString();
            }
    }

    public void onMultiplier()
    {
        checkInputFieldsValues();
        if ((firstInputField.text != null) && (secondInputField.text != null))
            if ((double.TryParse(firstInputField.text, out double resultFirst) && (double.TryParse(secondInputField.text, out double resultSecond))))
            {
                result.text = (resultFirst * resultSecond).ToString();
            }
    }

    public void onDivision(/*InputField first, InputField second*/)
    {
        checkInputFieldsValues();
        if ((firstInputField.text != null) && (secondInputField.text != null))
            if ((double.TryParse(firstInputField.text, out double resultFirst) && (double.TryParse(secondInputField.text, out double resultSecond))))
            {
                result.text = (resultFirst / resultSecond).ToString();
            }
    }
}
