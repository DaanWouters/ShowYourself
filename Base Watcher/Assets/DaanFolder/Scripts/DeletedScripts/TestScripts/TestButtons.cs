using UnityEngine;

public class TestButtons : MonoBehaviour
{



    [SerializeField] IDScript id;





    public void Pass()
    {
        if (id.passed) 
        {
            Debug.Log("You may pass");
        }
    }

    public void Deny()
    {
        if (id.denied)
        {
            Debug.Log("You may not pass");
        }
    }



        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
