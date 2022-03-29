using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace Assets._Scripts
{
    public class Ending : MonoBehaviour
    {
        void OnCollisionEnter2D(Collision2D collision)
        {
            SceneManager.LoadScene("EndScreen");
        }
    }
}