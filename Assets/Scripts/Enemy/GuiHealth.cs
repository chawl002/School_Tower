using UnityEngine;
using System.Collections;

public class GuiHealth : MonoBehaviour {
	public Vector3 pos;
	public float xOffset = -0.75f;
	public float yOffset = 	1f;
	public Texture aTexture;
	private float hp_decrease;
	
	// Use this for initialization
	void Start () {
		hp_decrease = 1f / GetComponent<EnemyHP> ().HP; 
	}
	
	// Update is called once per frame
	void Update () { 
		pos = Camera.main.WorldToScreenPoint(new Vector3(transform.position.x + xOffset, transform.position.y + yOffset,transform.position.z));
		pos.y = Screen.height - pos.y;
		
		
	}
	void OnGUI(){
		GUI.DrawTexture (new Rect (pos.x, pos.y, 30f * hp_decrease * GetComponent<EnemyHP> ().HP, 7f), aTexture);
	}
}