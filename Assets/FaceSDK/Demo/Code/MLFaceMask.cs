//
//  MLFace.cpp
//  MLRenderEngine
//
//  Created by xiaohui on 2016/11/14.
//  Copyright © 2016年 milook. All rights reserved.
//
using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using milook;
//using VacuumShaders.TheAmazingWireframeShader;
public class MLFaceMask : MonoBehaviour{
	private static int VERTEX_COUNT = 112;
	private float[] posArray;
	private int[] elementArray ;
	private float[] texcoordArray;
	private Mesh mesh;
	private Vector3[] vertexes;

	public List<Vector3> offsetList = new List<Vector3>(VERTEX_COUNT);
	void makeModel()
	{
		 int vertexCount = VERTEX_COUNT;
		 posArray = new float[] {
	        50.0f, 22.7696905383687f, 1,
	        50.0f, 37.9302464090068f, 1,
	        50.0f, 58.8265679058891f, 1,
	        50.0f, 51.8153397041402f, 1,
	        50.0f, 73.9818122429346f, 1,
	        50.0f, 77.0899442439292f, 1,
	        50.0f, 100.0f, 1,
	        50.0f, 84.2641644958471f, 1,
	        50.0f, 78.0302197578974f, 1,
	        66.5078222631017f, 4.44356546341241f, 1,
	        63.2312869398189f, 36.2943143758359f, 1,
	        56.6340363917648f, 40.9320892357144f, 1,
	        64.2844924669989f, 76.9419818349939f, 1,
	        59.1319229912945f, 98.3701351568759f, 1,
	        81.6178978449978f, 16.3717829754664f, 1,
	        74.0204693520368f, 31.0782193808817f, 1,
	        69.9908134926116f, 35.7659528827887f, 1,
	        71.0131451721678f, 42.8860876333977f, 1,
	        66.4374942106965f, 93.5108838905419f, 1,
	        78.7428314203579f, 34.924858497235f, 1,
	        86.8805884044923f, 39.9939449979605f, 1,
	        85.2213748397277f, 60.9927294473632f, 1,
	        86.4130531933392f, 49.9414467306889f, 1,
	        78.753062846241f, 80.2183050869492f, 1,
	        73.296825105345f, 87.3800594449744f, 1,
	        86.780581741715f, 30.675865632907f, 1,
	        63.0499765177725f, 30.6236830858084f, 1,
	        68.9409677927844f, 29.7987044960746f, 1,
	        57.2119023204341f, 53.8099276194872f, 1,
	        63.9074085208797f, 43.2633649625666f, 1,
	        60.8774837127595f, 60.425131508599f, 1,
	        53.8559495351494f, 73.0483538877306f, 1,
	        54.1681611872094f, 77.0637335279081f, 1,
	        60.1792977757699f, 80.5042779905714f, 1,
	        54.3707981844744f, 78.0021873410481f, 1,
	        55.0036389327206f, 83.0647930720116f, 1,
	        76.3086165961658f, 39.7690770753333f, 1,
	        50.0f, 0.0f, 1,
	        50.0f, 65.3645969263471f, 1,
	        56.6728263501468f, 64.6068392596842f, 1,
	        53.4484126339259f, 64.8742392652094f, 1,
	        81.987220468052f, 70.6055197047577f, 1f,
	        59.0845482068191f, 74.4220528179486f, 1f,
	        50.0f, 44.8727929550068f, 1f,
	        56.9880573778884f, 33.6413524462956f, 1f,
	        69.11094174295f, 36.703129392761f, 1f,
	        73.8492944768826f, 39.7054735528366f, 1f,
	        69.8776909088841f, 42.0432316745185f, 1f,
	        64.5483888266849f, 42.3261884525943f, 1f,
	        64.0412962189551f, 37.0993997000125f, 1f,
	        59.0933576985142f, 40.5777310480549f, 1f,
	        72.8471477625256f, 51.9459450702761f, 1f,
	        72.3461361579176f, 60.6925307015905f, 1f,
	        69.9337216161623f, 67.7492358119407f, 1f,
	        59.2263247957696f, 77.0028584939848f, 1f,
	        59.3276453257367f, 77.4720854005548f, 1f,
	        65.0295258540137f, 52.8779379191659f, 1f,
	        55.0269330585886f, 28.7951195968532f, 1f,
	        61.4221015699779f, 25.7477277491676f, 1f,
	        69.3082997079754f, 24.645010473561f, 1f,
	        76.3978994375641f, 26.4292551177443f, 1f,
	        81.9577254903235f, 30.9780648369488f, 1f,
	        33.4921777368983f, 4.44356546341241f, 1f,
	        36.7687130601811f, 36.2943143758359f, 1f,
	        43.3659636082352f, 40.9320892357144f, 1f,
	        35.7155075330011f, 76.9419818349939f, 1f,
	        40.8680770087055f, 98.3701351568759f, 1f,
	        18.3821021550022f, 16.3717829754664f, 1f,
	        25.9795306479632f, 31.0782193808817f, 1f,
	        30.0091865073884f, 35.7659528827887f, 1f,
	        28.9868548278322f, 42.8860876333977f, 1f,
	        33.5625057893035f, 93.5108838905419f, 1f,
	        21.2571685796421f, 34.924858497235f, 1f,
	        13.1194115955077f, 39.9939449979605f, 1f,
	        14.7786251602723f, 60.9927294473632f, 1f,
	        13.5869468066608f, 49.9414467306889f, 1f,
	        21.246937153759f, 80.2183050869492f, 1f,
	        26.703174894655f, 87.3800594449744f, 1f,
	        13.219418258285f, 30.675865632907f, 1f,
	        36.9500234822275f, 30.6236830858084f, 1f,
	        31.0590322072156f, 29.7987044960746f, 1f,
	        42.7880976795659f, 53.8099276194872f, 1f,
	        36.0925914791203f, 43.2633649625666f, 1f,
	        39.1225162872405f, 60.425131508599f, 1f,
	        46.1440504648506f, 73.0483538877306f, 1f,
	        45.8318388127906f, 77.0637335279081f, 1f,
	        39.8207022242301f, 80.5042779905714f, 1f,
	        45.6292018155256f, 78.0021873410481f, 1f,
	        44.9963610672794f, 83.0647930720116f, 1f,
	        23.6913834038342f, 39.7690770753333f, 1f,
	        43.3271736498532f, 64.6068392596842f, 1f,
	        46.5515873660741f, 64.8742392652094f, 1f,
	        18.012779531948f, 70.6055197047577f, 1f,
	        40.9154517931809f, 74.4220528179486f, 1f,
	        43.0119426221116f, 33.6413524462956f, 1f,
	        30.8890582570499f, 36.703129392761f, 1f,
	        26.1507055231174f, 39.7054735528366f, 1f,
	        30.1223090911159f, 42.0432316745185f, 1f,
	        35.4516111733151f, 42.3261884525943f, 1f,
	        35.9587037810449f, 37.0993997000125f, 1f,
	        40.9066423014858f, 40.5777310480549f, 1f,
	        27.1528522374744f, 51.9459450702761f, 1f,
	        27.6538638420824f, 60.6925307015905f, 1f,
	        30.0662783838377f, 67.7492358119407f, 1f,
	        40.7736752042304f, 77.0028584939848f, 1f,
	        40.6723546742633f, 77.4720854005548f, 1f,
	        34.9704741459863f, 52.8779379191659f, 1f,
	        44.9730669414114f, 28.7951195968532f, 1f,
	        38.5778984300221f, 25.7477277491676f, 1f,
	        30.6917002920247f, 24.645010473561f, 1f,
	        23.6021005624359f, 26.4292551177443f, 1f,
	        18.0422745096765f, 30.9780648369488f, 1
	    };
	    
	    //---
		texcoordArray=new float[] {
	        0.5f, 0.227697f,
	        0.5f, 0.379302f,
	        0.5f, 0.588266f,
	        0.5f, 0.518153f,
	        0.5f, 0.739818f,
	        0.5f, 0.770899f,
	        0.5f, 1.0f,
	        0.5f, 0.842642f,
	        0.5f, 0.780302f,
	        0.665078f, 0.0444357f,
	        0.630054f, 0.342202f,
	        0.56634f, 0.409321f,
	        0.642845f, 0.76942f,
	        0.591319f, 0.983701f,
	        0.816179f, 0.163718f,
	        0.740205f, 0.310782f,
	        0.698605f, 0.336843f,
	        0.707537f, 0.449521f,
	        0.664375f, 0.935109f,
	        0.787428f, 0.349249f,
	        0.868806f, 0.399939f,
	        0.852214f, 0.609927f,
	        0.864131f, 0.499414f,
	        0.787531f, 0.802183f,
	        0.732968f, 0.873801f,
	        0.867806f, 0.306759f,
	        0.6305f, 0.306237f,
	        0.68941f, 0.297987f,
	        0.572119f, 0.538099f,
	        0.641637f, 0.45302f,
	        0.608775f, 0.604251f,
	        0.538559f, 0.730484f,
	        0.541682f, 0.770637f,
	        0.601793f, 0.805043f,
	        0.543708f, 0.780022f,
	        0.550036f, 0.830648f,
	        0.763086f, 0.397691f,
	        0.5f, 0.0f,
	        0.5f, 0.653646f,
	        0.566728f, 0.646068f,
	        0.534484f, 0.648742f,
	        0.819872f, 0.706055f,
	        0.590845f, 0.744221f,
	        0.5f, 0.448728f,
	        0.569881f, 0.336414f,
	        0.691109f, 0.367031f,
	        0.738493f, 0.397055f,
	        0.698777f, 0.420432f,
	        0.645484f, 0.423262f,
	        0.640413f, 0.370994f,
	        0.590934f, 0.405777f,
	        0.728471f, 0.519459f,
	        0.723461f, 0.606925f,
	        0.699337f, 0.677492f,
	        0.592263f, 0.770029f,
	        0.593276f, 0.774721f,
	        0.650295f, 0.528779f,
	        0.550269f, 0.287951f,
	        0.614221f, 0.257477f,
	        0.693083f, 0.24645f,
	        0.763979f, 0.264293f,
	        0.819577f, 0.309781f,
	        0.334922f, 0.0444357f,
	        0.369946f, 0.342202f,
	        0.43366f, 0.409321f,
	        0.357155f, 0.76942f,
	        0.408681f, 0.983701f,
	        0.183821f, 0.163718f,
	        0.259795f, 0.310782f,
	        0.301395f, 0.336843f,
	        0.292463f, 0.449521f,
	        0.335625f, 0.935109f,
	        0.212572f, 0.349249f,
	        0.131194f, 0.399939f,
	        0.147786f, 0.609927f,
	        0.135869f, 0.499414f,
	        0.212469f, 0.802183f,
	        0.267032f, 0.873801f,
	        0.132194f, 0.306759f,
	        0.3695f, 0.306237f,
	        0.31059f, 0.297987f,
	        0.427881f, 0.538099f,
	        0.358363f, 0.45302f,
	        0.391225f, 0.604251f,
	        0.461441f, 0.730484f,
	        0.458318f, 0.770637f,
	        0.398207f, 0.805043f,
	        0.456292f, 0.780022f,
	        0.449964f, 0.830648f,
	        0.236914f, 0.397691f,
	        0.433272f, 0.646068f,
	        0.465516f, 0.648742f,
	        0.180128f, 0.706055f,
	        0.409155f, 0.744221f,
	        0.430119f, 0.336414f,
	        0.308891f, 0.367031f,
	        0.261507f, 0.397055f,
	        0.301223f, 0.420432f,
	        0.354516f, 0.423262f,
	        0.359587f, 0.370994f,
	        0.409066f, 0.405777f,
	        0.271529f, 0.519459f,
	        0.276539f, 0.606925f,
	        0.300663f, 0.677492f,
	        0.407737f, 0.770029f,
	        0.406724f, 0.774721f,
	        0.349705f, 0.528779f,
	        0.449731f, 0.287951f,
	        0.385779f, 0.257477f,
	        0.306917f, 0.24645f,
	        0.236021f, 0.264293f,
	        0.180423f, 0.309781f
	    };
	    
		elementArray = new int[]{
			35, 7, 13,
	        13, 7, 6,
	        34, 8, 35,
	        35, 8, 7,
	        33, 35, 18,
	        18, 35, 13,
	        25, 61, 20,
	        14, 61, 25,
	        9, 59, 14,
	        36, 20, 19,
	        19, 15, 36,
	        36, 15, 16,
	        46, 45, 47,
	        36, 22, 20,
	        17, 22, 36,
	        40, 2, 38,
	        34, 32, 8,
	        8, 32, 5,
	        12, 55, 33,
	        33, 34, 35,
	        54, 55, 12,
	        12, 33, 24,
	        24, 33, 18,
	        23, 12, 24,
	        40, 38, 31,
	        31, 38, 4,
	        31, 4, 32,
	        32, 4, 5,
	        31, 32, 42,
	        42, 54, 12,
	        40, 31, 39,
	        2, 40, 30,
	        30, 40, 39,
	        52, 41, 21,
	        41, 53, 12,
	        23, 41, 12,
	        42, 39, 31,
	        15, 27, 16,
	        16, 27, 10,
	        27, 26, 10,
	        1, 57, 0,
	        0, 57, 58,
	        37, 0, 9,
	        0, 58, 9,
	        9, 58, 59,
	        11, 10, 44,
	        44, 10, 26,
	        48, 49, 50,
	        49, 48, 45,
	        45, 48, 47,
	        3, 28, 43,
	        43, 28, 11,
	        28, 29, 11,
	        17, 51, 22,
	        3, 2, 28,
	        28, 2, 30,
	        22, 51, 21,
	        43, 11, 1,
	        11, 44, 1,
	        36, 16, 46,
	        46, 16, 45,
	        36, 46, 17,
	        17, 46, 47,
	        11, 50, 10,
	        10, 50, 49,
	        11, 29, 50,
	        50, 29, 48,
	        16, 10, 45,
	        45, 10, 49,
	        17, 47, 29,
	        29, 47, 48,
	        29, 56, 51,
	        29, 51, 17,
	        52, 51, 56,
	        30, 53, 52,
	        12, 53, 42,
	        30, 39, 53,
	        42, 53, 39,
	        52, 53, 41,
	        21, 51, 52,
	        42, 32, 54,
	        32, 55, 54,
	        33, 55, 34,
	        32, 34, 55,
	        28, 56, 29,
	        52, 56, 30,
	        30, 56, 28,
	        1, 44, 57,
	        58, 57, 26,
	        26, 57, 44,
	        59, 58, 27,
	        27, 58, 26,
	        60, 59, 27,
	        60, 27, 15,
	        15, 61, 60,
	        19, 61, 15,
	        20, 61, 19,
	        60, 61, 14,
	        14, 59, 60,
	        88, 66, 7,
	        66, 6, 7,
	        87, 88, 8,
	        88, 7, 8,
	        86, 71, 88,
	        71, 66, 88,
	        78, 73, 111,
	        67, 78, 111,
	        62, 67, 109,
	        89, 72, 73,
	        72, 89, 68,
	        89, 69, 68,
	        96, 97, 95,
	        89, 73, 75,
	        70, 89, 75,
	        91, 38, 2,
	        87, 8, 85,
	        8, 5, 85,
	        65, 86, 105,
	        86, 88, 87,
	        104, 65, 105,
	        65, 77, 86,
	        77, 71, 86,
	        76, 77, 65,
	        91, 84, 38,
	        84, 4, 38,
	        84, 85, 4,
	        85, 5, 4,
	        84, 93, 85,
	        93, 65, 104,
	        91, 90, 84,
	        2, 83, 91,
	        83, 90, 91,
	        102, 74, 92,
	        92, 65, 103,
	        76, 65, 92,
	        93, 84, 90,
	        68, 69, 80,
	        69, 63, 80,
	        80, 63, 79,
	        1, 0, 107,
	        0, 108, 107,
	        37, 62, 0,
	        0, 62, 108,
	        62, 109, 108,
	        64, 94, 63,
	        94, 79, 63,
	        98, 100, 99,
	        99, 95, 98,
	        95, 97, 98,
	        3, 43, 81,
	        43, 64, 81,
	        81, 64, 82,
	        70, 75, 101,
	        3, 81, 2,
	        81, 83, 2,
	        75, 74, 101,
	        43, 1, 64,
	        64, 1, 94,
	        89, 96, 69,
	        96, 95, 69,
	        89, 70, 96,
	        70, 97, 96,
	        64, 63, 100,
	        63, 99, 100,
	        64, 100, 82,
	        100, 98, 82,
	        69, 95, 63,
	        95, 99, 63,
	        70, 82, 97,
	        82, 98, 97,
	        82, 101, 106,
	        82, 70, 101,
	        102, 106, 101,
	        83, 102, 103,
	        65, 93, 103,
	        83, 103, 90,
	        93, 90, 103,
	        102, 92, 103,
	        74, 102, 101,
	        93, 104, 85,
	        85, 104, 105,
	        86, 87, 105,
	        85, 105, 87,
	        81, 82, 106,
	        102, 83, 106,
	        83, 81, 106,
	        1, 107, 94,
	        108, 79, 107,
	        79, 94, 107,
	        109, 80, 108,
	        80, 79, 108,
	        110, 80, 109,
	        110, 68, 80,
	        68, 110, 111,
	        72, 68, 111,
	        73, 72, 111,
	        110, 67, 111,
	        67, 110, 109
	    };
	}
	void OnPreRender() {
		GL.wireframe = true;
	}
	void OnPostRender() {
		GL.wireframe = false;
	}
	List<Vector2> uv;
	IEnumerator Start(){
		makeModel ();
		uv = new List<Vector2> ();
		int j = 0;
		for (int i=0; i<texcoordArray.Length; i+=2) {
			j++;
			Vector3 temp = new Vector3 (texcoordArray[i],1-texcoordArray[i+1]);
			uv.Add (temp);
		}
		mesh = GetComponent<MeshFilter> ().mesh = new Mesh ();
		//scale = transform.localScale;
		yield return 1;
		if(MilookEngine.instance.source.getRotation ()==270){
			Vector3 s = transform.localScale;
			s.y = -s.y;
			transform.localScale = s;
		}
	}
	void init(){
		mesh.uv=uv.ToArray();
		mesh.SetIndices (elementArray, MeshTopology.Triangles, 0);
	}
	bool isFirst=true;
	void OnTrack(MilookEngine.TrackerData trackerData){//return;
		GetComponent<MeshRenderer> ().enabled = trackerData.error==0;
		if (trackerData.error != 0) {
			
			return;
		}
		float offsetX =(1.0f/MilookEngine.instance.GetWidth())/10.0f;
		float offsetY =(1.0f/MilookEngine.instance.GetHeight())/10.0f;
		for (int i = 0; i < trackerData.maskVertexes.Count; i++) {
			Vector3 v = trackerData.maskVertexes [i];
			float f = v.y;
			v.y = -v.z*offsetY;
			v.z = f;
			v.x = v.x* offsetX;

//			v.x = v.x* offsetY;
//			v.y = v.y * offsetX;
			//v.z = v.z * offsetX;
			trackerData.maskVertexes [i] = v;
		}
		vertexes = trackerData.maskVertexes.ToArray();

		if (mesh != null) {
			mesh.vertices = vertexes;


			if (isFirst) {
				init ();
				isFirst = false;
			}
			//GetComponent<MeshFilter> ().mesh = WireframeGenerator.GenerateFast(mesh);
		}
	}
}
