using UnityEngine;

class Dog : MonoBehaviour
{
    [SerializeField] string dogName = "Morzsa";  // field / mezo / osztaly valtozo
    [SerializeField] int born = 1993;            // field / mezo / osztaly valtozo
    [SerializeField] bool isBiting;
    [SerializeField] float mass = 15f;
    [SerializeField] float age;
    // Field-et nem kotelezo definialni

    void Start() // GameObject Letrejon
    { 
        int i = 6;  // Lokalis valtozo = metoduson belul deklaraljuk

        Debug.Log("My name is " + dogName);
    }

    void OnValidate() // Akkor fut le, ha modositom a beallitasokat Inspectorban
    {
        // Fejlesztoi eszkoz
        // Sosem fut le vegleges jatekban

        age = 2022 - born;

        int helloMyNewVariable;
    }
}
