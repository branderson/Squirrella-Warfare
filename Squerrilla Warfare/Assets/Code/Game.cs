using UnityEngine;
using JetBrains.Annotations;

public class Game : MonoBehaviour {
	// ReSharper disable once MemberCanBePrivate.Global
	public static Game game;
	// ReSharper disable once MemberCanBePrivate.Global
	public static Assets assets;
	[UsedImplicitly] void Start () {
		game = this;
		assets = GetComponent<Assets>();
	}
	[UsedImplicitly] void Update () {
		//if (Input.GetKeyDown("1"))
		//	SpawnSquirrell();
	}
	[UsedImplicitly] void OnGUI () {
    Cursor.visible = showMenu;
    Cursor.lockState = showMenu ? CursorLockMode.None : CursorLockMode.Locked;
    //Draw Loadout UI
    GUI.Box (new Rect (Screen.width/2 - 100, 20, 200, 220), "Loadout");
    GUI.Box (new Rect (50, 2*Screen.height/3, 
	}
	public static void JoinedGame () {
		SpawnSquirrell();
    showMenu = false;
	}
	public static void SpawnSquirrell () {Network.Instantiate(assets.squirrell, Vector3.zero, Quaternion.identity, 0);}
	public static bool showMenu;
}
