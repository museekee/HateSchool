using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneGosu : MonoBehaviour
{
    public void GotoMain() {
        SceneManager.LoadScene("SelectStage");
    }
}
