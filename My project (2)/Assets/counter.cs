using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class counter : MonoBehaviour
{
    public float delay = 1;
    public float minus = 10;
    public float count =0;
    public Text textcounter;
    public bool k = false;

 IEnumerator Counter() {//ф ия с взможностью задержки
       
        while (true)
        {
            if (!k)
            {
                count++;
            }
                yield return new WaitForSeconds(delay);// задержка в 1 сек
            
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Counter());// запускает счетчик
    }

    // Update is called once per frame
    void Update()
    {
        textcounter.text = ""+count;//т к принимает строку ставим кавычки и добав перемен
    }
    private void OnCollisionEnter(Collision collision)//когда два обьекта соприкасаются
    {
        count = count - minus;
        //StopCoroutine(Counter());// остановка счетчика
        k = true;
    }
}
