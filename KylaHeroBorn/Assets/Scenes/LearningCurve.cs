using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{

    private int CurrentAge = 19;
    public int AddedAge = 1;
    public float Bday = 12.29f;
    public string FirstName = "Kyla" + "Hardrict";
    public bool IsAuthor = true;
     

    // Start is called before the first frame update
    void Start()
    {
        int characterLevel = 32;
        int NextSkillLevel = GenerateCharacter("Avarice", characterLevel);
        Debug.Log(NextSkillLevel);

       
      

        GenerateCharacter("Avarice", characterLevel);
        ComputeAge();
        Debug.Log($"Hello, My Name is {FirstName}. I am {CurrentAge} years old. This year I will be turning {CurrentAge + AddedAge}. My background consists of");


    }

    /// <summary>
    /// Time for action - adding comments
    /// Computes a modified age integer
    /// </summary>


    void ComputeAge()
    {
        Debug.Log(CurrentAge + AddedAge);
    }

    public int GenerateCharacter(string name, int level)
    {
      
        return level += 5;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
