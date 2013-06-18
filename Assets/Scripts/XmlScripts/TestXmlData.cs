using UnityEngine;
using System.Collections;

public class TestXmlData : MonoBehaviour {

	public void Start ()
	{
		UUnitTestSuite suite = new UUnitTestSuite ();
		suite.AddAll (typeof(GetXmlDataTest));
		UUnitTestResult result = suite.Run ();
		Debug.Log (result.Summary ());
	}
}
