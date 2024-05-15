using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    int Point = 0;
    int Exp = 0;
    int Lv = 0;
    public float u = 0.1f;
    int assignmentPoint=0;
    [SerializeField] Text PointText;
    [SerializeField] Text LvText;
    [SerializeField] Button button;
    public float cooldownTime = 2f;
    // Start is called before the first frame update
    void Start()
    {
        PointText.text = "0";
        button.onClick.AddListener(OnButtonClick);
        FindAnyObjectByType<contro>().Control(u);
    }
    public void AddPoint(int p)
    {
        Point += p;
        PointText.text = "" + Point;
        Exp++;
        if (Exp % 5 == 0)
        {
            Lv++;
            assignmentPoint++;
        }
    }

    public float uPawer {

        get
        {
            return u;
        }

    }

    private void Update()
    {
        LvText.text = "" + Lv;
        if (assignmentPoint>=1 && Input.GetKey(KeyCode.R))
        {
            cooldownTime -= 0.5f;
            assignmentPoint--;
        }
        if (assignmentPoint>=1 && Input.GetKey(KeyCode.T))
        {
            u += 0.1f;
            assignmentPoint--;
            //FindAnyObjectByType<contro>().Control(u);
        }
    }
    void OnButtonClick()
    {
        // ボタンを押せないようにする
        button.interactable = false;

        // cooldownTime秒後にボタンを再び押せるようにする
        Invoke("EnableButton", cooldownTime);
    }

    void EnableButton()
    {
        // ボタンを再び押せるようにする
        button.interactable = true;
    }
}
