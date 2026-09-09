using System;
using System.Xml;
using TMPro;
using UnityEngine;

public class IDScript : MonoBehaviour
{

    #region Variables

    [Header("ID Card Variables")]

    [SerializeField] public TextMeshProUGUI Name;
    [SerializeField] public TextMeshProUGUI ExpireDate;
    [SerializeField] public TextMeshProUGUI UniqueNumber;

    [SerializeField] public bool passed;
    [SerializeField] public bool denied;

    public DateTime randomdateTime { get; set; } // a DateTime variable that is used to check the date and time of the level


    [Header("Strings")]

    private string[] PossibleNames = { "Alice", "Bob", "Charlie", "David", "Eve", "Fay", "Grace", "Hank", "Ivy", "Jack", "Kara", "Liam" };

    #endregion




    #region Randomizer

    internal string NameRandomizer()
    {
        int randomIndex = UnityEngine.Random.Range(0, PossibleNames.Length);
        return PossibleNames[randomIndex];
    }
    int GenerateUniqueID()
    {
        int uniqueID = UnityEngine.Random.Range(1000000, 0001);
        return uniqueID;
    }

    void DateChecker()
    {
        randomdateTime = new DateTime(UnityEngine.Random.Range(2024, 2028), UnityEngine.Random.Range(1, 13), UnityEngine.Random.Range(1, 29)); // set the random date and time to a random date and time between January 1, 2024 and December 31, 2027
        
        if (randomdateTime < DateTime.Now) // check if the date and time is less than the current date and time
        {
            denied = true; // set the passed variable of the LevelButton script to true
            passed = false; // set the denied variable of the LevelButton script to false


        }
        else if (randomdateTime > DateTime.Now) // check if the date and time is greater than the current date and time
        {
            passed = true; // set the passed variable of the LevelButton script to true
            denied = false; // set the denied variable of the LevelButton script to false
        }
        else
        {
            passed = true; // set the passed variable of the LevelButton script to true
            denied = false; // set the denied variable of the LevelButton script to false
        }

    }

    #endregion







    void Start()
    {
        DateChecker();

        Name.text = "" + NameRandomizer();
        ExpireDate.text = randomdateTime.ToString("dd/MM/yyyy");
        UniqueNumber.text = "" + GenerateUniqueID();

        //Debug.Log(randomdateTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
