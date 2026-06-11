using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class ItemGenerator : MonoBehaviour
{
    [SerializeField] GameObject tikuwa;
    [SerializeField] GameObject dumbbell;
    [SerializeField] GameObject manager;
    float span = 0.5f;
    float delta = 0;
    float dumbbellDelta = 0;
    float time = 11;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        delta += Time.deltaTime;
        dumbbellDelta += Time.deltaTime;
        //if (time > 10) { span = 0.3f; }
        if (delta > span)
        {
            delta = 0;
            GameObject tiku = Instantiate(tikuwa);
            tiku.transform.position = Vector3.zero;
        }
        if (dumbbellDelta > span + 1)
        {
            dumbbellDelta = 0;
            GameObject dumb = Instantiate(dumbbell);
            dumb.transform.position = Vector3.zero;
        }
        if (time < 0)
        {
            time = 0;
            delta = 0;
            dumbbellDelta = 0;
        }
        
       
       
    }
}
