using UnityEngine;
using System.Collections;
using System.IO;

public class MapLoader : MonoBehaviour {
	public string mapname;

	public Transform TileA;
	public Transform TileB;
	public Transform TileC;
	public Transform TileD;
	public Transform TileE;
	public Transform TileF;
	public Transform TileG;
	public Transform TileH;
	public Transform TileI;
	public Transform TileJ;
	public Transform TileK;
	public Transform TileL;
	public Transform TileM;
	public Transform TileN;
	public Transform TileO;
	public Transform TileP;
	public Transform TileQ;
	public Transform TileR;
	public Transform TileS;
	public Transform TileT;
	public Transform TileU;
	public Transform TileV;
	public Transform TileW;
	public Transform TileX;
	public Transform TileY;
	public Transform TileZ;

	// Use this for initialization
	void Start () {
		string fileName = mapname + ".txt";
		StreamReader sr = new StreamReader(Application.dataPath + "/Stages/" + fileName);
		string fileContents = sr.ReadToEnd();
		sr.Close();

		float x = -16;
		float y = 16;
		string[] lines = fileContents.Split("\n"[0]);
		foreach (string line in lines) {
			foreach (char tile in line) {
				Vector3 pos = new Vector3(x, y, 0);
				Quaternion ori = new Quaternion();
				ori.SetLookRotation(new Vector3(0, 0, -1), new Vector3(0, 1, 0));
				switch(tile){
				case 'a':
					Instantiate (TileA, pos, ori);
					break;
				case 'b':
					Instantiate (TileB, pos, ori);
					break;
				case 'c':
					Instantiate (TileC, pos, ori);
					break;
				case 'd':
					Instantiate (TileD, pos, ori);
					break;
				case 'e':
					Instantiate (TileE, pos, ori);
					break;
				case 'f':
					Instantiate (TileF, pos, ori);
					break;
				case 'g':
					Instantiate (TileG, pos, ori);
					break;
				case 'h':
					Instantiate (TileH, pos, ori);
					break;
				case 'i':
					Instantiate (TileI, pos, ori);
					break;
				case 'j':
					Instantiate (TileJ, pos, ori);
					break;
				case 'k':
					Instantiate (TileK, pos, ori);
					break;
				case 'l':
					ori.SetLookRotation(new Vector3(0, 0, -1), new Vector3(0, -1, 0));
					Instantiate (TileL, pos, ori);
					break;
				case 'm':
					Instantiate (TileM, pos, ori);
					break;
				case 'n':
					Instantiate (TileN, pos, ori);
					break;
				case 'o':
					Instantiate (TileO, pos, ori);
					break;
				case 'p':
					Instantiate (TileP, pos, ori);
					break;
				case 'q':
					Instantiate (TileQ, pos, ori);
					break;
				case 'r':
					Instantiate (TileR, pos, ori);
					break;
				case 's':
					Instantiate (TileS, pos, ori);
					break;
				case 't':
					Instantiate (TileT, pos, ori);
					break;
				case 'u':
					Instantiate (TileU, pos, ori);
					break;
				case 'v':
					Instantiate (TileV, pos, ori);
					break;
				case 'w':
					Instantiate (TileW, pos, ori);
					break;
				case 'x':
					Instantiate (TileX, pos, ori);
					break;
				case 'y':
					Instantiate (TileY, pos, ori);
					break;
				case 'z':
					Instantiate (TileZ, pos, ori);
					break;
				default:
					break;
				}

				x+=5;
			}
			y--;
			x = -16;
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
