using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KillCount : MonoBehaviour
{
    private TextMeshProUGUI text;
    
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        text.text = "Kill count: " + 0.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Kill count: " + DestroyEnemy.killCount;
    }
}
