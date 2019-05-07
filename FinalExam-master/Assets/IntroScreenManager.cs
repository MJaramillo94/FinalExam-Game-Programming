using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class IntroScreenManager : MonoBehaviour
{

    public AudioMixer audioMixer;
    public Toggle toggle;
    public Slider volume;
    public Dropdown dropdown;
    public Text DropdownChoice;
    public Text toggleText;
    public Text volumeText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(toggle.isOn)
        {
            toggleText.text = "Toggle is enabled";
        }
        else 
        {
            toggleText.text = "Toggle has been Disabled.";
        }

        switch(dropdown.value)
        {
            case 1:
                DropdownChoice.text = "You have selected option 1.";
                break;
            case 2:
                DropdownChoice.text = "You have selected option 2.";
                break;
            case 3:
                DropdownChoice.text = "You have selected option 3.";
                break;

        }

        volumeText.text = "Volume: " + volume.value.ToString();

    }

    public void StartGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }
}
