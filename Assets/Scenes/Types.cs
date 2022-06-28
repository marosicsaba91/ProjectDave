using UnityEngine;

class Types : MonoBehaviour
{
    void Start()
    {
        int i = 6;          // Integer = Egesz szamok
        float f = 5.76f;    // Floating Point Numbers = Tizedes tort szamok
        float f2 = 4;

        string s = "My Text";
        Debug.Log(s);
        Debug.Log("usidgfg");

        bool b1 = true;
        bool b2 = false;

        float f3 = 3.5f + 3;    // Osszeadas
        float f4 = 4 / 3;       // NEM: 1.333...      HANEM: 1
        float f5 = 4f / 3;      // 1.333...

        string st = "Hello" + "World";    // Osszefuz
        Debug.Log(st + "!");

        float a = 2, b = 3, c = 5;
        string s1 = "A", s2 = "B", s3 = "C";

        string q1 = a + b + s1; // 5A
        string q2 = a + s1 + b; // 2A3
        string q3 = s1 + a + b; // A23

        // * magasabb rendu muvelet, mint a +
        // + azonos rendu muvelet, mint a -
        // + azonos rendu muvelet, mint a + (osszefuzes)

        // Casting
        int ii = 6;
        float ff = ii;    // Implicit Casting
        ii = (int) ff;    // Explicit Casting

        float ff2 = 34.98f;
        string ss = ff2.ToString();
    }
}
