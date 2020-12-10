using UnityEngine;
using System.Collections;
using CourseraUtils;
using UnityEngine.SceneManagement;

public class MainMenuScreen : MonoBehaviour
{
	public Texture2D m_LogoTexture;
	public GUISkin m_Skin;
	public AudioClip m_FXSound;

	void OnGUI()
	{
		GUI.skin=m_Skin;
		GUI.DrawTexture(GUIController.GetRectangleGUI(0.0f, 0.0f, 0.18984375f, 0.4472222222222222f), m_LogoTexture);
		GUI.Label(GUIController.GetRectangleGUI(0.2f, 0.8f, 0.6f, 0.1f), "- Select Level -", "MainMenuLabelStyle");
		bool boton_nivel_1 = GUI.Button(GUIController.GetRectangleGUI(0.45f, 0.5f, 0.1f, 0.1f), "Level 1", "MainMenuLabelStyle");
		bool boton_nivel_2 = GUI.Button(GUIController.GetRectangleGUI(0.45f, 0.6f, 0.1f, 0.1f), "Level 2", "MainMenuLabelStyle");

        if (boton_nivel_1)
        {
			GetComponent<AudioSource>().PlayOneShot(m_FXSound);
			SceneManager.LoadScene("Nivel 1");
		}
        if (boton_nivel_2)
        {
			GetComponent<AudioSource>().PlayOneShot(m_FXSound);
			SceneManager.LoadScene("Nivel 2");
		}
	}
}
