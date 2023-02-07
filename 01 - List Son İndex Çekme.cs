/*
	Unity
	
	List'te son indekse ulaşmanın farklı bir yöntemi
*/


public List<Vector3> myList = new();

void start(){


	myList[myList.Count -1] = Vector3.zero;
	
	myList[^1] = Vector3.zero;
}