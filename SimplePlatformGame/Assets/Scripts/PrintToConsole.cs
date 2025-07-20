using System.Linq;
using UnityEngine;

public class PrintToConsole : MonoBehaviour
{
    void Start()
    {
        string[] randomDialogue = new string[] { "Ate too many doughnuts today...", "I'm a horse. What do you want from me?", "This vomit is greener than Shrek" };
        byte randomIndex = (byte)Random.Range(0, randomDialogue.Length);
        Debug.Log(randomDialogue.ElementAt(randomIndex));
    }

    void Update()
    {
        
    }
}