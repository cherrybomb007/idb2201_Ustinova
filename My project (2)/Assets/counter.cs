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

 IEnumerator Counter() {//� �� � ����������� ��������
       
        while (true)
        {
            if (!k)
            {
                count++;
            }
                yield return new WaitForSeconds(delay);// �������� � 1 ���
            
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Counter());// ��������� �������
    }

    // Update is called once per frame
    void Update()
    {
        textcounter.text = ""+count;//� � ��������� ������ ������ ������� � ����� �������
    }
    private void OnCollisionEnter(Collision collision)//����� ��� ������� �������������
    {
        count = count - minus;
        //StopCoroutine(Counter());// ��������� ��������
        k = true;
    }
}
