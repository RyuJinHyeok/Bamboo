using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowShooting : MonoBehaviour
{
    public GameObject arrow;
    public Transform firePos;

    [SerializeField]
    private float cool_down;

    private float timer;
    public static bool keep = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject newarrow;
        timer += Time.deltaTime;

        if (timer > cool_down && keep)
        {
            newarrow = Instantiate(arrow, firePos.transform.position, firePos.transform.rotation);
            Destroy(newarrow, 15f);
            timer = 0;
        }
        
    }
}
