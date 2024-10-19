using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    // Start is called before the first frame update

    public Text txtEquation;
    public Text txtScore;
    public InputField inpAnswer;
    int result;
    int score = 0;

    private void Start()
    {
        NewEquation();
    }

    public void NewEquation()
    {
        int number1 = Random.Range(100, 201);
        int number2 = Random.Range(0, 101);
        result = number1 + number2;

        txtEquation.text = number1 + " + " + number2 + " = ";
    }

    public void checkResult()
    {
        if(result.ToString() == inpAnswer.text)
        {
            score++;
            txtScore.text = score.ToString(); 
            NewEquation();
        }
        else
        {
           
        }

        inpAnswer.text = "";
    }
}
