using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using UnityEngine.UI;
public class TextEffect : MonoBehaviour
{
    public Text Buy_cookie_txt;
    private string m_text = "그렇게 추자와 춘자는 쿠키를 사러 갔다.";
    private string second_text = "얼마 후 ... ";
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(_typing());
    }

    IEnumerator _typing()
    {
        yield return new WaitForSeconds(0.5f);
        //타이핑 효과
        for (int i = 0; i <= m_text.Length; i++)
        {
            Buy_cookie_txt.text = m_text.Substring(0, i);
            //딜레이 주기
            yield return new WaitForSeconds(0.15f);
        }
        StartCoroutine(_typing2());
    }

    IEnumerator _typing2()
    {
        yield return new WaitForSeconds(0.5f);
        //타이핑 효과
        for (int i = 0; i < second_text.Length; i++)
        {
            Buy_cookie_txt.text = second_text.Substring(0, i);
            //딜레이주기
            yield return new WaitForSeconds(0.15f);
        }
    }
}
