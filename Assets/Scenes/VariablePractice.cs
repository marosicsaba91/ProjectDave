using UnityEngine;

class VariablePractice : MonoBehaviour
{
    // comment 1
    /* comment 2 */
    void Start()
    {
        int variable; // Declaration
        variable = 5; // Define

        Debug.Log(variable); // 5

        variable = 8;
        Debug.Log(variable); // 8

        int a = 5;
        int x, y, z;
        int k = 1, l = 2, m = 3;

        x = a + k; // 6
        y = 2 - l; // 0
        z = 3 * 5; // 15
        z = l / m; // 0
        int mod = 11 % 4; // 3  (Modulo : maradék)

        // Egyzserusitett alakok

        x = x + a;  // 11
        x += a;     // 16    Ugzanaz

        x = x - 3;  // 13
        x -= 3;     // 10

        x *= m;     // 30
        x /= l;     // 15

        x++;        // 16
        ++x;        // 17 (NE HASZNALJUK)

        x--;        // 16
        --x;        // 15

        // Muveleti sorrend

        x = 3 + 4 + 1;      // 8
        x = 3 * 4 + 1;      // 13
        x = 3 + 4 * 1;      // 7     C# betartja a matematikai sorrendet
        x = 3 * (4 + 1);    // 8
    }
}
